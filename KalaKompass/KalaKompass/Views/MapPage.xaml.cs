using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KalaKompass.Views
{
    public partial class MapPage : ContentPage
    {
        private List<PinData> allPins;
        private List<PinData> displayedPins;

        private ListView pinsListView;
        private SearchBar searchBar;

        public MapPage()
        {
            InitializeComponent();

            double latitude = 58.885381;
            double longitude = 25.549918;
            string apiKey = "AIzaSyCul7gCzLmFH_NjS9_f6gsG4SULb_Y_Gnw";//Mellikovi API :)

            // Sample pin data
            var pin1 = new PinData { Latitude = 58.120553, Longitude = 24.304987, Label = "Liivi Laht", Info = "Liigid:Koha, Ahven" };
            var pin2 = new PinData { Latitude = 59.665660, Longitude = 25.259910, Label = "Soome laht", Info = "Liigid:Vaal, Latikas" };
            var pin3 = new PinData { Latitude = 58.770115, Longitude = 27.396407, Label = "Peipsi järv", Info = "Liigid:Särg, Koha" };
            var pin4 = new PinData { Latitude = 58.661988, Longitude = 21.815354, Label = "Läänemeri", Info = "Liigid: Pingviin" };
            var pin5 = new PinData { Latitude = 58.296336, Longitude = 26.018214, Label = "Võrtsjärv", Info = "Liigid: Ahven, Haug, Latikas" };
            var pin6 = new PinData { Latitude = 59.112723, Longitude = 25.351912, Label = "Paunküla veehoidla", Info = "Liigid: Paunkala, Räim" };

            allPins = new List<PinData> { pin1, pin2, pin3, pin4, pin5, pin6 };
            displayedPins = new List<PinData>(allPins);

            var htmlContent = GenerateHtmlContent(apiKey, latitude, longitude, displayedPins.ToArray());

            googleMapView.Source = new HtmlWebViewSource { Html = htmlContent };

            // Add pins dynamically after the WebView has loaded
            googleMapView.Navigated += (sender, args) =>
            {
                AddPins(displayedPins.ToArray());
            };

            // Create a SearchBar
            searchBar = new SearchBar
            {
                Placeholder = "Search by species...",
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };
            searchBar.TextChanged += OnSearchTextChanged;

            // Create a ListView to display pins
            pinsListView = new ListView
            {
                ItemTemplate = new DataTemplate(() =>
                {
                    var nameLabel = new Label();
                    nameLabel.SetBinding(Label.TextProperty, "Label");

                    var infoLabel = new Label();
                    infoLabel.SetBinding(Label.TextProperty, "Info");

                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Padding = new Thickness(10, 5),
                            Children = { nameLabel, infoLabel }
                        }
                    };
                }),
                HasUnevenRows = true,
                ItemsSource = displayedPins,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            // StackLayout to hold the map, search bar, and pins ListView
            var stackLayout = new StackLayout
            {
                Children = { googleMapView, searchBar, pinsListView },
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            Content = stackLayout;
        }

        private string GenerateHtmlContent(string apiKey, double centerLatitude, double centerLongitude, params PinData[] pins)
        {
            var jsMarkers = string.Join("", pins.Select(pin =>
                $@"addMarker({pin.Latitude}, {pin.Longitude}, '{pin.Label}', '{pin.Info}');"));

            return $@"<html>
                <body>
                    <div id='map' style='width: 100%; height: 90%;'></div>
                    <script async defer
                            src='https://maps.googleapis.com/maps/api/js?key={apiKey}&callback=initMap'>
                    </script>
                    <script>
                        var markers = [];

                        function initMap() {{
                            var map = new google.maps.Map(document.getElementById('map'), {{
                                center: {{lat: {centerLatitude}, lng: {centerLongitude}}},
                                zoom: 6,
                                mapTypeId: 'satellite'
                            }});

                            // Function to clear all markers
                            function clearMarkers() {{
                                for (var i = 0; i < markers.length; i++) {{
                                    markers[i].setMap(null);
                                }}
                                markers = [];
                            }}

                            // Function to add a marker
                            function addMarker(lat, lng, label, info) {{
                                var marker = new google.maps.Marker({{
                                    position: {{lat: lat, lng: lng}},
                                    map: map,
                                    title: label
                                }});

                                var infowindow = new google.maps.InfoWindow({{
                                    content: '<div><strong>' + label + '</strong></div><div>' + info + '</div>'
                                }});

                                // Event listener to open the info window when marker is clicked
                                marker.addListener('click', function() {{
                                    infowindow.open(map, marker);
                                }});

                                markers.push(marker);
                            }}

                            // Example of adding pins
                            {jsMarkers}
                        }}

                        // Function to clear all markers (called from C# code)
                        function clearMarkersFromCode() {{
                            clearMarkers();
                        }}
                    </script>
                </body>
            </html>";
        }

        private void AddPins(params PinData[] pins)
        {
            foreach (var pin in pins)
            {
                googleMapView.EvaluateJavaScriptAsync($"addMarker({pin.Latitude}, {pin.Longitude}, '{pin.Label}', '{pin.Info}')");
            }
        }

        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            // Filter pins based on the search text
            var searchText = e.NewTextValue.ToLower();
            displayedPins = allPins
                .Where(pin => pin.Info.ToLower().Contains(searchText))
                .ToList();

            // Update the displayed pins on the map
            googleMapView.EvaluateJavaScriptAsync("clearMarkersFromCode();");
            AddPins(displayedPins.ToArray());

            // Update the ListView with filtered pins
            pinsListView.ItemsSource = displayedPins;
        }

        // Sample class for pin data
        private class PinData
        {
            public double Latitude { get; set; }
            public double Longitude { get; set; }
            public string Label { get; set; }
            public string Info { get; set; }
        }
    }
}

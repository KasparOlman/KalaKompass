using Microsoft.Maui.Controls;

namespace KalaKompass.Views
{
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();

            double latitude = 58.885381;
            double longitude = 25.549918;
            string apiKey = "AIzaSyBz1eES6CyIBLu2KAt92nQtmDzYOa9Dsj8";

            // Sample pin data
            var pin1 = new PinData { Latitude = 58.885381, Longitude = 25.549918, Label = "Pin 1", Info = "This is Pin 1" };
            var pin2 = new PinData { Latitude = 58.890108, Longitude = 25.551257, Label = "Pin 2", Info = "This is Pin 2" };

            var htmlContent = GenerateHtmlContent(apiKey, latitude, longitude);

            googleMapView.Source = new HtmlWebViewSource { Html = htmlContent };

            // Add pins dynamically after the WebView has loaded
            googleMapView.Navigated += (sender, args) =>
            {
                AddPins(pin1, pin2);
            };
        }

        private string GenerateHtmlContent(string apiKey, double centerLatitude, double centerLongitude)
        {
            return $@"<html>
                        <body>
                            <div id='map' style='width: 100%; height: 100%;'></div>
                            <script async defer
                                    src='https://maps.googleapis.com/maps/api/js?key={apiKey}&callback=initMap'>
                            </script>
                            <script>
                                function initMap() {{
                                    var map = new google.maps.Map(document.getElementById('map'), {{
                                        center: {{lat: {centerLatitude}, lng: {centerLongitude}}},
                                        zoom: 18,
                                        mapTypeId: 'satellite'
                                    }});
                                    
                                    // Global array to store markers
                                    var markers = [];

                                    // Function to add a marker
                                    function addMarker(lat, lng, label, info) {{
                                        var marker = new google.maps.Marker({{
                                            position: {{lat: lat, lng: lng}},
                                            map: map,
                                            title: label
                                        }});

                                        var infowindow = new google.maps.InfoWindow({{
                                            content: info
                                        }});

                                        // Event listener to open the info window when marker is clicked
                                        marker.addListener('click', function() {{
                                            infowindow.open(map, marker);
                                        }});

                                        markers.push(marker);
                                    }}

                                    // Example of adding pins
                                    addMarker({centerLatitude}, {centerLongitude}, 'Center Pin', 'This is the center pin');
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

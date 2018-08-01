using Wisej.Web;
using Wisej.Web.Ext.GoogleMaps;

namespace Wisej.GoogleMaps
{
    public partial class GeocodeDetails : Form
    {
        private readonly GeocoderResult[] _geocodes;
        private readonly string _lastQuery;

        public GeocodeDetails(GeocoderResult[] geocodes, string lastQuery)
        {
            InitializeComponent();
            _geocodes = geocodes;
            _lastQuery = lastQuery;
        }

        private void GeocodeDetails_Load(object sender, System.EventArgs e)
        {
            var result = _geocodes.Length == 1 ? "result" : "results";
            this.title.Text = $"{_geocodes.Length} {result} for\r\n{_lastQuery}";

            for (var index = 0; index < _geocodes.Length; index++)
            {
                var geocoderResult = _geocodes[index];
                var currentRootNode = new TreeNode($"Geocoder Result #{index + 1}");

                AddTreeNodeForProperty(currentRootNode, geocoderResult.FormattedAddress, "Formatted Address");
                if (geocoderResult.PartialMatch)
                    AddTreeNodeForProperty(currentRootNode, geocoderResult.PartialMatch.ToString(), "Partial Match");
                AddTreeNodeForProperty(currentRootNode, geocoderResult.PlaceId, "Place Id");
                AddTreeNodeForArray(currentRootNode, geocoderResult.Types, "Types");
                AddTreeNodeForArray(currentRootNode, geocoderResult.PostcodeLocalities, "Postcode Localities");
                AddTreeNodeForGeometry(currentRootNode, geocoderResult.GeocodeGeometry);
                AddTreeNodeForAddressComponents(currentRootNode, geocoderResult.AddressComponents);

                treeView.Nodes.Add(currentRootNode);
            }

            ExpandRoot();
        }

        private void buttonCollapseAll_Click(object sender, System.EventArgs e)
        {
            this.buttonExpandRoot.Text = "Expand Root";
            this.treeView.CollapseAll();
        }


        private void buttonExpandRoot_Click(object sender, System.EventArgs e)
        {
            this.buttonExpandRoot.Text = "Expand Root";
            ExpandRoot();
        }

        private void ExpandRoot()
        {
            foreach (var node in this.treeView.Nodes)
            {
                node.Expand();
                foreach (var subNode in node.Nodes)
                {
                    subNode.Collapse();
                }
            }
        }


        private void buttonExpandAll_Click(object sender, System.EventArgs e)
        {
            this.buttonExpandRoot.Text = "Collapse to Root";
            this.treeView.ExpandAll();
        }

        private void AddTreeNodeForProperty(TreeNode rootNode, string property, string label)
        {
            if (string.IsNullOrWhiteSpace(property))
                return;

            rootNode.Nodes.Add(new TreeNode($"{label}: {property}"));
        }

        private void AddTreeNodeForArray(TreeNode rootNode, string[] propertyArray, string label)
        {
            if (propertyArray == null || propertyArray.Length == 0)
                return;

            var subTree = new TreeNode(label);

            foreach (var property in propertyArray)
            {
                if (string.IsNullOrWhiteSpace(property))
                    continue;

                subTree.Nodes.Add(new TreeNode(property));
            }

            rootNode.Nodes.Add(subTree);
        }

        private void AddTreeNodeForAddressComponents(TreeNode rootNode,
            GeocoderResult.AddressComponent[] addressComponents)
        {
            if (addressComponents == null || addressComponents.Length == 0)
                return;

            var folder = new TreeNode($"Address Components ({addressComponents.Length})");

            for (var index = 0; index < addressComponents.Length; index++)
            {
                var subTree = new TreeNode($"Address Components #{index + 1}");

                var addressComponent = addressComponents[index];
                AddTreeNodeForProperty(subTree, addressComponent.ShortName, "Short Name");
                AddTreeNodeForProperty(subTree, addressComponent.LongName, "Long Name");
                AddTreeNodeForArray(subTree, addressComponent.PostcodeLocalities, "Postcode Localities");
                AddTreeNodeForArray(subTree, addressComponent.Types, "Types");


                folder.Nodes.Add(subTree);
            }

            rootNode.Nodes.Add(folder);
        }

        private void AddTreeNodeForGeometry(TreeNode rootNode, GeocoderResult.Geometry geomotry)
        {
            if (geomotry == null)
                return;

            var subTree = new TreeNode("Geometry");

            if (geomotry.Location != null)
                AddTreeNodeForProperty(subTree, geomotry.Location.ToString(), "Location");
            if (geomotry.LocationType.HasValue)
                AddTreeNodeForProperty(subTree, geomotry.LocationType.Value.ToString(), "Location Type");

            if (subTree.Nodes.Count > 0)
                rootNode.Nodes.Add(subTree);
        }
    }
}
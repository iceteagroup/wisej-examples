namespace ComponentMixin
{
    public class MyListBox : Wisej.Web.ListBox
    {
        protected override void OnWebRender(dynamic config)
        {
            base.OnWebRender((object)config);

            config.className = "my.ListBox";
        }
    }
}
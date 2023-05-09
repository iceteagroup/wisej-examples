using System;
using Wisej.Web;
using Wisej.Ext.ClearScript;
using Microsoft.ClearScript;

namespace Wisej.Sample.ClrScript
{
    public partial class frmEvents : Form
    {
        ScriptEngine engine;
       
        public frmEvents()
        {
            InitializeComponent();
        }

        private void frmEvents_Load(object sender, EventArgs e)
        {
            var oFrmTestForm = new frmTestForm();
            engine = ClearScript.Create(EngineType.V8);
            engine.AddHostObject("form", this);
            engine.AddHostType("Form2", typeof(frmTestForm));
            engine.AddHostType("alert", typeof(AlertBox));
            engine.AddHostType("msgBox", typeof(MessageBox));

            engine.Execute(@"
                
                form.btnForm.Click.connect((s,e) => {
                 form.btnForm.Text = 'Clicked';
                 let form2 = new Form2();
                 form2.label1.Text = 'Opened from an event connected to ClearScript';
                 form2.Show();
            });
            ");

            engine.Execute(@"
                form.txtKeyPress.KeyPress.connect((s,e) => {
                 form.lblKeyPressResult.Text = 'Key pressed: '+e.KeyChar;
            });
            ");


            engine.Execute(@"
                form.btnAlert.Click.connect((s,e) => {
                 alert.Show('Hello from ClearScript');
            });
            ");


            if (!oFrmTestForm.IsDisposed) { 
            engine.Execute(@"
                form.btnMsgBox.Click.connect((s,e) => {
                 msgBox.Show('Hello, I came from ClearScript :D');
            });
            ");
            }
            else
            {
                engine.AddHostObject("form2", oFrmTestForm);
            }
        }
    }
}

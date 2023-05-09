using System;
using Wisej.Web;
using Wisej.Ext.ClearScript;
using Microsoft.ClearScript;
namespace Wisej.Sample.ClrScript
{
    public partial class frmCommandLine : Form
    {
        private ScriptEngine engine;
        private string code = "";
        public frmCommandLine()
        {
            InitializeComponent();
            
        }

        private void frmCommandLine_Load(object sender, EventArgs e)
        {
            this.txtCommandLine.Text += "\n";
            engine = ClearScript.Create(EngineType.V8);
            engine.AddHostObject("log", this);
        }


        public void Import(string objName,string objType,string objNameSpace)
        {
            var type = Type.GetType(objNameSpace+'.'+objType);
            var obj = Activator.CreateInstance(type);
            engine.AddHostObject(objName, obj);
        }

        public void Output(dynamic obj)
        {
            this.txtCommandLine.Text += obj.ToString() + "\n";
            this.txtCommandLine.SelectionStart = this.txtCommandLine.Text.Length;
        }

        private void txtCommandLine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                code += this.txtCommandLine.Lines[this.txtCommandLine.Lines.Length - 2];
                if (code.Contains("exec"))
                {
                    code = code.Replace("exec", "");
                    engine.Execute(code);
                    code = "";
                }

                if (code.Contains("clear"))
                {
                    code = "";
                    this.txtCommandLine.Clear();
                    this.txtCommandLine.SelectionStart = this.txtCommandLine.Text.Length;
                }
                if (code.Contains("help"))
                {
                    this.txtCommandLine.Text += "How to use: \n";
                    this.txtCommandLine.Text += "Write your code like you would on a regular text editor, then type in exec on a new line to execute your commands \n";
                    this.txtCommandLine.Text += "To clear the CLI, just type in clear: \n";
                    this.txtCommandLine.Text += "To switch to another engine, just type in switch followed by the engine type: \n";
                    this.txtCommandLine.Text += "example: switch vbscript to code using vbscipt, type switch v8 to go back to javascript \n";
                    this.txtCommandLine.Text += "you can dynamically import Objects/Classes in this CLI, just type in import <your_object_name> <object_namespace> <object_type> \n";
                    this.txtCommandLine.Text += "Using ClearScript is fun :D \n";
                    this.txtCommandLine.SelectionStart = this.txtCommandLine.Text.Length;
                    code = "";
                }

                if (code.Contains("switch"))
                {
                    if (code.Contains("vbscript") || code.Contains("vbs"))
                    {
                        try
                        {
                            engine = ClearScript.Create(EngineType.VBScript);
                            engine.AddHostObject("log", this);
                            this.txtCommandLine.Text += "Switched to VBScript \n";
                            code = "";
                            this.txtCommandLine.SelectionStart = this.txtCommandLine.Text.Length;
                        }
                        catch (ExecutionEngineException ex)
                        {
                            Output(ex.Message);
                            code = "";
                        }
                    }
                    else
                    if (code.Contains("v8"))
                    {
                        engine = ClearScript.Create(EngineType.V8);
                        engine.AddHostObject("log", this);
                        this.txtCommandLine.Text += "Switched to V8 \n";
                        code = "";
                        this.txtCommandLine.SelectionStart = this.txtCommandLine.Text.Length;
                    }
                    else
                    {
                        Output("Missing engine type, please type 'switch vbscript' or 'switch v8' to change engine types");
                        code = "";
                    }
                }

                if (code.Contains("import"))
                {

                    string command = code.Substring(code.IndexOf("import"));
                    var command_array = command.Split(' ');
                    if (command.Length < 4)
                    {

                        Output("Error, please type import <object_name> <object_namespace> <object_type>");
                        code = "";
                    }
                    else
                    {
                        try
                        {
                            Import(command_array[1], command_array[3], command_array[2]);
                            code = "";
                        }
                        catch
                        {
                            Output("Please verify that you typed the right command, or verify that the type of object you provided exists");
                        }
                    }
                }


                e.Handled = true;
            }
        }
    }
}

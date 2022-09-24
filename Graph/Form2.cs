using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ZedGraph;


namespace Graph
{
    public partial class Form2 : Form
    {
        List<string> speciality = new List<string>();
        public Form2(List<string> spec)
        {
            speciality = spec;
            InitializeComponent();
            DrawGraph();
        }

        public void DrawGraph()
        {
            GraphPane pane = zedGraphControl1.GraphPane;
            pane.Title.Text = "Специальности";
            pane.CurveList.Clear();

            //Random random = new Random();

            int count_spec = speciality.Count;

            /*bool[] bools = new bool[3];
            for (int i = 0; i < count_spec; i++)
            {
                if (speciality[i] == "ИСИТ")
                    bools[0] = true;
                else if (speciality[i] == "ИВТ")
                    bools[1] = true;
                else if (speciality[i] == "ПИ")
                    bools[2] = true;
            }
            int tmp = 0;
            foreach (bool b in bools)
            {
                if (b == true)
                    tmp += 1;

            }*/
            double[] YValues = new double[3];
            double[] XValues = new double[3] { 0, 1, 2};
            
            for (int i = 0; i < count_spec; i++)
            {
                /*for (int j = 0; j < tmp; i++)
                {
                    XValues[i] = i;
                    //YValues[i] = random.Next(1, 10);
                    if (speciality[i] == "ИСИТ")
                        YValues[0]++;
                    else if (speciality[i] == "ИВТ")
                        YValues[1]++;
                    else if (speciality[i] == "ПИ")
                        YValues[2]++;
                }*/
                //XValues[i] = i;
                //YValues[i] = random.Next(1, 10);
                if (speciality[i] == "ИСИТ")
                    YValues[0]++;
                else if (speciality[i] == "ИВТ")
                    YValues[1]++;
                else if (speciality[i] == "ПИ")
                    YValues[2]++;
            }
            
            BarItem bar = pane.AddBar("Специальности", XValues, YValues, Color.Blue);

            pane.BarSettings.MinBarGap = 1f;
            //pane.BarSettings.ClusterScaleWidth = 2f;

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nirvana1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //initialize the material data
            int boilingpt1 = 0;
            int meltingpt1 = 0;
            int specheat1 = 0;
            int boilingpt2 = 0;
            int meltingpt2 = 0;
            int specheat2 = 0;
            int LHF1 = 0;
            int LHF2 = 0;
            int LHV1 = 0;
            int LHV2 = 0;
            int intQ1 = 0;
            int intQ2 = 0;
            int finalTemp = 0;
            int rawfinal = 0;
            string answer;

            //start of data collection --------------------------------------------------------

            //temp1 and mass1 collect and convert
            string strtemp1;
            int inttemp1;
            string strQ1;
            strtemp1 = tempBox1.Text.ToString();
            inttemp1 = Convert.ToInt32(strtemp1);


            string strmass1;
            int intmass1;
            strmass1 = massBox1.Text.ToString();
            intmass1 = Convert.ToInt32(strmass1);

            // ***** USE INTMASS1 AND INTTEMP1 *****


            //temp 2 and mass 2 collect and convert
            string strtemp2;
            int inttemp2;
            string strQ2;
            strtemp2 = tempBox2.Text.ToString();
            inttemp2 = Convert.ToInt32(strtemp2);


            string strmass2;
            int intmass2;
            strmass2 = massBox2.Text.ToString();
            intmass2 = Convert.ToInt32(strmass2);

            //          ************** Special protocol for water **************



            if (materialBox1.SelectedItem.ToString() == "Water" && materialBox2.SelectedItem.ToString() == "Water")
            {
                boilingpt1 = 100;
                meltingpt1 = 0;
                LHF1 = 333000;
                LHV1 = 2260000;

                boilingpt2 = 100;
                meltingpt1 = 0;
                LHF2 = 333000;
                LHV1 = 2260000;

                // STUPID CONVINIENCE SHTUFF //

                if (inttemp1 < 0)
                {
                    stateBox1.Text = "S";
                    specheat1 = 2090;
                }
                if (inttemp1 > 100)
                {
                    stateBox1.Text = "G";
                    specheat1 = 2010;
                }
                if (inttemp2 < 0)
                {
                    stateBox2.Text = "S";
                    specheat2 = 2090;
                }
                if (inttemp2 > 100)
                {
                    stateBox2.Text = "G";
                    specheat2 = 2010;
                }
                if (inttemp1 > 0 && inttemp1 < 100)
                {
                    stateBox1.Text = "L";
                    specheat1 = 4186;
                }
                if (inttemp2 > 0 && inttemp2 < 100)
                {
                    stateBox2.Text = "L";
                    specheat2 = 4186;
                }

                // STUPID CONVINIENCE SHTUFF //

                // first crack at Q1 and 2

                //1
                // If it is identified as liquid
                if (inttemp1 >= 0 && inttemp1 <= 100 && stateBox1.SelectedItem.ToString() == "L")
                {
                    specheat1 = 4186;
                    if (inttemp1 > inttemp2)
                    {
                        intQ1 = intmass1 * specheat1 * (boilingpt1 - inttemp1);
                    }
                    if (inttemp1 < inttemp2)
                    {
                        intQ1 = intmass1 * specheat1 * (meltingpt1 - inttemp1);
                    }
                }

                // 2
                // If it is identified as liquid
                if (inttemp2 >= 0 && inttemp2 <= 100 && stateBox2.SelectedItem.ToString() == "L")
                {
                    specheat1 = 4186;
                    if (inttemp2 > inttemp1)
                    {
                        intQ2 = intmass2 * specheat2 * (boilingpt2 - inttemp2);
                    }
                    if (inttemp2 < inttemp1)
                    {
                        intQ2 = intmass2 * specheat2 * (meltingpt2 - inttemp2);
                    }
                }

                //1
                // If it is identified as a solid
                if (inttemp1 <= 0 && stateBox1.SelectedItem.ToString() == "S")
                {
                    if (inttemp1 > inttemp2)
                    {
                        finalTemp = ((intmass1 * specheat1 * inttemp1) + (intmass2 * specheat2 * inttemp2)) / ((intmass1 * specheat1) + (intmass2 * specheat2));
                        answer = finalTemp.ToString();
                        lblAnswer.Text = answer;
                    }
                    if (inttemp1 < inttemp2)
                    {
                        if (inttemp1 == 0)
                        {
                            intQ1 = intmass1 * LHF1;
                        }
                        if (inttemp1 < 0)
                        {
                            intQ1 = intmass1 * specheat1 * (meltingpt1 - inttemp1);
                        }
                    }
                }

                //2
                // If it is identified as a solid
                if (inttemp2 <= 0 && stateBox2.SelectedItem.ToString() == "S")
                {
                    if (inttemp2 > inttemp1)
                    {
                        finalTemp = ((intmass1 * specheat1 * inttemp1) + (intmass2 * specheat2 * inttemp2)) / ((intmass1 * specheat1) + (intmass2 * specheat2));
                        answer = finalTemp.ToString();
                        lblAnswer.Text = answer;
                    }
                    if (inttemp2 < inttemp1)
                    {
                        if (inttemp2 == 0)
                        {
                            intQ2 = intmass2 * LHF2;
                        }
                        if (inttemp2 < 0)
                        {
                            intQ2 = intmass2 * specheat2 * (meltingpt2 - inttemp2);
                        }
                    }
                }

                //1
                // If it is identified as a gas
                if (inttemp1 >= 100 && stateBox1.SelectedItem.ToString() == "G")
                {
                    if (inttemp1 > inttemp2)
                    {
                        finalTemp = ((intmass1 * specheat1 * inttemp1) + (intmass2 * specheat2 * inttemp2)) / ((intmass1 * specheat1) + (intmass2 * specheat2));
                        answer = finalTemp.ToString();
                        lblAnswer.Text = answer;
                    }
                    if (inttemp1 < inttemp2)
                    {
                        if (inttemp1 == 0)
                        {
                            intQ1 = intmass1 * LHV1;
                        }
                        if (inttemp1 < 0)
                        {
                            intQ1 = intmass1 * specheat1 * (boilingpt1 - inttemp1);
                        }
                    }
                }

                //2
                // If it is identified as a gas
                if (inttemp2 >= 100 && stateBox2.SelectedItem.ToString() == "G")
                {
                    if (inttemp2 > inttemp1)
                    {
                        finalTemp = ((intmass1 * specheat1 * inttemp1) + (intmass2 * specheat2 * inttemp2)) / ((intmass1 * specheat1) + (intmass2 * specheat2));
                        answer = finalTemp.ToString();
                        lblAnswer.Text = answer;
                    }
                    if (inttemp2 < inttemp1)
                    {
                        if (inttemp2 == 0)
                        {
                            intQ2 = intmass2 * LHV2;
                        }
                        if (inttemp2 < 0)
                        {
                            intQ2 = intmass2 * specheat2 * (boilingpt2 - inttemp2);
                        }
                    }
                }

            }

            else
            {

                //Ethyl Alchohol
                if (materialBox1.SelectedItem.ToString() == "Ethyl Alchohol")
                {
                    boilingpt1 = 79;
                    meltingpt1 = -114;
                    specheat1 = 2430;
                }
                // Lead
                if (materialBox1.SelectedItem.ToString() == "Lead")
                {
                    specheat1 = 128;
                }
                //Aluminum
                if (materialBox1.SelectedItem.ToString() == "Aluminum")
                {
                    specheat1 = 100;
                }
                //Silver
                if (materialBox1.SelectedItem.ToString() == "Silver")
                {
                    specheat1 = 234;
                }
                //Gold
                if (materialBox1.SelectedItem.ToString() == "Gold")
                {
                    specheat1 = 129;
                }
                //copper
                if (materialBox1.SelectedItem.ToString() == "Copper")
                {
                    specheat1 = 387;
                }
                if (materialBox1.SelectedItem.ToString() == "Water")
                {
                    boilingpt1 = 100;
                    meltingpt1 = 0;
                    specheat1 = 4186;
                    LHF1 = 333000;
                    LHV1 = 2260000;
                }
                //Ethyl Alchohol
                if (materialBox2.SelectedItem.ToString() == "Ethyl Alchohol")
                {
                    boilingpt2 = 79;
                    meltingpt2 = -114;
                    specheat2 = 2430;
                }
                // Lead
                if (materialBox2.SelectedItem.ToString() == "Lead")
                {
                    specheat2 = 128;
                }
                //Aluminum
                if (materialBox2.SelectedItem.ToString() == "Aluminum")
                {
                    specheat2 = 100;
                }
                //Silver
                if (materialBox2.SelectedItem.ToString() == "Silver")
                {
                    specheat2 = 234;
                }
                //Gold
                if (materialBox2.SelectedItem.ToString() == "Gold")
                {
                    specheat2 = 129;
                }
                //copper
                if (materialBox2.SelectedItem.ToString() == "Copper")
                {
                    specheat2 = 387;
                }
                if (materialBox2.SelectedItem.ToString() == "Water")
                {
                    boilingpt2 = 100;
                    meltingpt2 = 0;
                    specheat2 = 4186;
                    LHF2 = 333000;
                    LHV2 = 2260000;
                }


               

                // ****** USE INTTEMP2 AND INTMASS2 *****

                finalTemp = ((intmass1 * specheat1 * inttemp1) + (intmass2 * specheat2 * inttemp2)) / ((intmass1 * specheat1) + (intmass2 * specheat2));

                answer = finalTemp.ToString();
                lblAnswer.Text = answer;
            }
        }


        private void Label8_Click(object sender, EventArgs e)
        {
            //put nothing, just a misclick
        }

        private void TempBox1_TextChanged(object sender, EventArgs e)
        {
            //misclick
        }

        private void MaterialBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialBox1.SelectedItem.ToString() == "Ethyl Alchohol")
            {
                stateBox1.Text = "L";
            }
            if (materialBox1.SelectedItem.ToString() == "Lead")
            {
                stateBox1.Text = "S";
            }
            if (materialBox1.SelectedItem.ToString() == "Aluminum")
            {
                stateBox1.Text = "S";
            }
            if (materialBox1.SelectedItem.ToString() == "Silver")
            {
                stateBox1.Text = "S";
            }
            if (materialBox1.SelectedItem.ToString() == "Gold")
            {
                stateBox1.Text = "S";
            }
            if (materialBox1.SelectedItem.ToString() == "Copper")
            {
                stateBox1.Text = "S";
            }
        }

        private void MaterialBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialBox2.SelectedItem.ToString() == "Ethyl Alchohol")
            {
                stateBox2.Text = "L";
            }
            if (materialBox2.SelectedItem.ToString() == "Lead")
            {
                stateBox2.Text = "S";
            }
            if (materialBox2.SelectedItem.ToString() == "Aluminum")
            {
                stateBox2.Text = "S";
            }
            if (materialBox2.SelectedItem.ToString() == "Silver")
            {
                stateBox2.Text = "S";
            }
            if (materialBox2.SelectedItem.ToString() == "Gold")
            {
                stateBox2.Text = "S";
            }
            if (materialBox2.SelectedItem.ToString() == "Copper")
            {
                stateBox2.Text = "S";
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            // misclick
        }
    }
}

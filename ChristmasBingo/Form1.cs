using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace ChristmasBingo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BigNumberButton.Text = "-";
            PastNumber1Button.Text = "-";
            PastNumber2Button.Text = "-";
            PastNumber3Button.Text = "-";

            foreach (var button in this.Controls.OfType<Button>())
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            }
        }

        int currentNumber;
        List<int> pastNumber = new List<int>();
        SpeechSynthesizer syn = new SpeechSynthesizer();

        void GenerateNumber()
        {
            Random rnd = new Random();
            do
            {
                currentNumber = rnd.Next(1, 100);
            } while (pastNumber.Contains(currentNumber));
            pastNumber.Add(currentNumber);
            
            if (InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(delegate
                {
                    BigNumberButton.Refresh();
                    BigNumberButton.Text = currentNumber.ToString();

                    if (pastNumber.Count == 2)
                    {
                        PastNumber1Button.Text = pastNumber[pastNumber.Count - 2].ToString();
                    }
                    else if (pastNumber.Count == 3)
                    {
                        PastNumber2Button.Text = pastNumber[pastNumber.Count - 3].ToString();
                        PastNumber1Button.Text = pastNumber[pastNumber.Count - 2].ToString();
                    }
                    else if (pastNumber.Count >= 4)
                    {
                        PastNumber3Button.Text = pastNumber[pastNumber.Count - 4].ToString();
                        PastNumber2Button.Text = pastNumber[pastNumber.Count - 3].ToString();
                        PastNumber1Button.Text = pastNumber[pastNumber.Count - 2].ToString();
                    }

                    switch (currentNumber)
                    {
                        case 1:
                            currentNumber = 1;
                            button1.Text = 1.ToString();
                            break;

                        case 2:
                            currentNumber = 2;
                            button2.Text = 2.ToString();
                            break;

                        case 3:
                            currentNumber = 3;
                            button3.Text = 3.ToString();
                            break;

                        case 4:
                            currentNumber = 4;
                            button4.Text = 4.ToString();
                            break;

                        case 5:
                            currentNumber = 5;
                            button5.Text = 5.ToString();
                            break;

                        case 6:
                            currentNumber = 6;
                            button6.Text = 6.ToString();
                            break;

                        case 7:
                            currentNumber = 7;
                            button7.Text = 7.ToString();
                            break;

                        case 8:
                            currentNumber = 8;
                            button8.Text = 8.ToString();
                            break;

                        case 9:
                            currentNumber = 9;
                            button9.Text = 9.ToString();
                            break;

                        case 10:
                            currentNumber = 10;
                            button10.Text = 10.ToString();
                            break;

                        case 11:
                            currentNumber = 11;
                            button11.Text = 11.ToString();
                            break;

                        case 12:
                            currentNumber = 12;
                            button12.Text = 12.ToString();
                            break;

                        case 13:
                            currentNumber = 13;
                            button13.Text = 13.ToString();
                            break;

                        case 14:
                            currentNumber = 14;
                            button14.Text = 14.ToString();
                            break;

                        case 15:
                            currentNumber = 15;
                            button15.Text = 15.ToString();
                            break;

                        case 16:
                            currentNumber = 16;
                            button16.Text = 16.ToString();
                            break;

                        case 17:
                            currentNumber = 17;
                            button17.Text = 17.ToString();
                            break;

                        case 18:
                            currentNumber = 18;
                            button18.Text = 18.ToString();
                            break;

                        case 19:
                            currentNumber = 19;
                            button19.Text = 19.ToString();
                            break;

                        case 20:
                            currentNumber = 20;
                            button20.Text = 20.ToString();
                            break;

                        case 21:
                            currentNumber = 21;
                            button21.Text = 21.ToString();
                            break;

                        case 22:
                            currentNumber = 22;
                            button22.Text = 22.ToString();
                            break;

                        case 23:
                            currentNumber = 23;
                            button23.Text = 23.ToString();
                            break;

                        case 24:
                            currentNumber = 24;
                            button24.Text = 24.ToString();
                            break;


                        case 25:
                            currentNumber = 25;
                            button25.Text = 25.ToString();
                            break;

                        case 26:
                            currentNumber = 26;
                            button26.Text = 26.ToString();
                            break;

                        case 27:
                            currentNumber = 27;
                            button27.Text = 27.ToString();
                            break;

                        case 28:
                            currentNumber = 28;
                            button28.Text = 28.ToString();
                            break;

                        case 29:
                            currentNumber = 29;
                            button29.Text = 29.ToString();
                            break;

                        case 30:
                            currentNumber = 30;
                            button30.Text = 30.ToString();
                            break;

                        case 31:
                            currentNumber = 31;
                            button31.Text = 31.ToString();
                            break;

                        case 32:
                            currentNumber = 32;
                            button32.Text = 32.ToString();
                            break;

                        case 33:
                            currentNumber = 33;
                            button33.Text = 33.ToString();
                            break;

                        case 34:
                            currentNumber = 34;
                            button34.Text = 34.ToString();
                            break;

                        case 35:
                            currentNumber = 35;
                            button35.Text = 35.ToString();
                            break;

                        case 36:
                            currentNumber = 36;
                            button36.Text = 36.ToString();
                            break;

                        case 37:
                            currentNumber = 37;
                            button37.Text = 37.ToString();
                            break;

                        case 38:
                            currentNumber = 38;
                            button38.Text = 38.ToString();
                            break;

                        case 39:
                            currentNumber = 39;
                            button39.Text = 39.ToString();
                            break;

                        case 40:
                            currentNumber = 40;
                            button40.Text = 40.ToString();
                            break;

                        case 41:
                            currentNumber = 41;
                            button41.Text = 41.ToString();
                            break;

                        case 42:
                            currentNumber = 42;
                            button42.Text = 42.ToString();
                            break;

                        case 43:
                            currentNumber = 43;
                            button43.Text = 43.ToString();
                            break;

                        case 44:
                            currentNumber = 44;
                            button44.Text = 44.ToString();
                            break;

                        case 45:
                            currentNumber = 45;
                            button45.Text = 45.ToString();
                            break;

                        case 46:
                            currentNumber = 46;
                            button46.Text = 46.ToString();
                            break;

                        case 47:
                            currentNumber = 47;
                            button47.Text = 47.ToString();
                            break;

                        case 48:
                            currentNumber = 48;
                            button48.Text = 48.ToString();
                            break;
                        case 49:
                            currentNumber = 49;
                            button49.Text = 49.ToString();
                            break;

                        case 50:
                            currentNumber = 50;
                            button50.Text = 50.ToString();
                            break;

                        case 51:
                            currentNumber = 51;
                            button51.Text = 51.ToString();
                            break;

                        case 52:
                            currentNumber = 52;
                            button52.Text = 52.ToString();
                            break;

                        case 53:
                            currentNumber = 53;
                            button53.Text = 53.ToString();
                            break;

                        case 54:
                            currentNumber = 54;
                            button54.Text = 54.ToString();
                            break;

                        case 55:
                            currentNumber = 55;
                            button55.Text = 55.ToString();
                            break;

                        case 56:
                            currentNumber = 56;
                            button56.Text = 56.ToString();
                            break;

                        case 57:
                            currentNumber = 57;
                            button57.Text = 57.ToString();
                            break;

                        case 58:
                            currentNumber = 58;
                            button58.Text = 58.ToString();
                            break;

                        case 59:
                            currentNumber = 59;
                            button59.Text = 59.ToString();
                            break;

                        case 60:
                            currentNumber = 60;
                            button60.Text = 60.ToString();
                            break;

                        case 61:
                            currentNumber = 61;
                            button61.Text = 61.ToString();
                            break;

                        case 62:
                            currentNumber = 62;
                            button62.Text = 62.ToString();
                            break;

                        case 63:
                            currentNumber = 63;
                            button63.Text = 63.ToString();
                            break;

                        case 64:
                            currentNumber = 64;
                            button64.Text = 64.ToString();
                            break;

                        case 65:
                            currentNumber = 65;
                            button65.Text = 65.ToString();
                            break;

                        case 66:
                            currentNumber = 66;
                            button66.Text = 66.ToString();
                            break;

                        case 67:
                            currentNumber = 67;
                            button67.Text = 67.ToString();
                            break;

                        case 68:
                            currentNumber = 68;
                            button68.Text = 68.ToString();
                            break;

                        case 69:
                            currentNumber = 69;
                            button69.Text = 69.ToString();
                            break;

                        case 70:
                            currentNumber = 70;
                            button70.Text = 70.ToString();
                            break;

                        case 71:
                            currentNumber = 71;
                            button71.Text = 71.ToString();
                            break;

                        case 72:
                            currentNumber = 72;
                            button72.Text = 72.ToString();
                            break;

                        case 73:
                            currentNumber = 73;
                            button73.Text = 73.ToString();
                            break;

                        case 74:
                            currentNumber = 74;
                            button74.Text = 74.ToString();
                            break;

                        case 75:
                            currentNumber = 75;
                            button75.Text = 75.ToString();
                            break;

                        case 76:
                            currentNumber = 76;
                            button76.Text = 76.ToString();
                            break;

                        case 77:
                            currentNumber = 77;
                            button77.Text = 77.ToString();
                            break;

                        case 78:
                            currentNumber = 78;
                            button78.Text = 78.ToString();
                            break;

                        case 79:
                            currentNumber = 79;
                            button79.Text = 79.ToString();
                            break;

                        case 80:
                            currentNumber = 80;
                            button80.Text = 80.ToString();
                            break;

                        case 81:
                            currentNumber = 81;
                            button81.Text = 81.ToString();
                            break;

                        case 82:
                            currentNumber = 82;
                            button82.Text = 82.ToString();
                            break;

                        case 83:
                            currentNumber = 83;
                            button83.Text = 83.ToString();
                            break;

                        case 84:
                            currentNumber = 84;
                            button84.Text = 84.ToString();
                            break;

                        case 85:
                            currentNumber = 85;
                            button85.Text = 85.ToString();
                            break;

                        case 86:
                            currentNumber = 86;
                            button86.Text = 86.ToString();
                            break;

                        case 87:
                            currentNumber = 87;
                            button87.Text = 87.ToString();
                            break;

                        case 88:
                            currentNumber = 88;
                            button88.Text = 88.ToString();
                            break;

                        case 89:
                            currentNumber = 89;
                            button89.Text = 89.ToString();
                            break;

                        case 90:
                            currentNumber = 90;
                            button90.Text = 90.ToString();
                            break;

                        case 91:
                            currentNumber = 91;
                            button91.Text = 91.ToString();
                            break;

                        case 92:
                            currentNumber = 92;
                            button92.Text = 92.ToString();
                            break;

                        case 93:
                            currentNumber = 93;
                            button93.Text = 93.ToString();
                            break;

                        case 94:
                            currentNumber = 94;
                            button94.Text = 94.ToString();
                            break;

                        case 95:
                            currentNumber = 95;
                            button95.Text = 95.ToString();
                            break;

                        case 96:
                            currentNumber = 96;
                            button96.Text = 96.ToString();
                            break;

                        case 97:
                            currentNumber = 97;
                            button97.Text = 97.ToString();
                            break;

                        case 98:
                            currentNumber = 98;
                            button98.Text = 98.ToString();
                            break;

                        case 99:
                            currentNumber = 99;
                            button99.Text = 99.ToString();
                            break;
                    }

                    if (pastNumber.Count == 99)
                    {
                        MessageBox.Show("Finished");
                    }
                }));
            }
            syn.Speak(currentNumber.ToString());
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                GenerateNumber();
            });
        }
    }
}

using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO.App
{
    public partial class Form1 : Form
    {

        public static string XName = "X";
        public static string OName = "O";
        public int OWins = 0;
        public int XWins = 0;
        public static string XO = "X";
        List<Button> btns = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();


            lblO.Text = "player :" + OName;
            lblX.Text = "player :" + XName;

            btns.Add(new Button());
            btns.Add(btnUL);
            btns.Add(btnU);
            btns.Add(btnUR);
            btns.Add(btnL);
            btns.Add(btnC);
            btns.Add(btnR);
            btns.Add(btnDL);
            btns.Add(btnD);
            btns.Add(btnDR);
            Setlblnbt(lblnbt);
        }

        private static void Setlblnbt(Label lblnbt)
        {
            if (XO == "X")
            {
                lblnbt.Text = XName + " نوبت";
            }
            else
            {
                lblnbt.Text = OName + " نوبت";
            }
        }

        private bool Insert(Button btn)
        {
            if (btn.Text == "")
            {
                btn.Text = XO;
                ChangeXO(lblnbt);
                return true;
            }
            else
            {
                MessageBox.Show("نمیتوانید وارد کنید!!");
                return false;
            }
        }

        private static void ChangeXO(Label lblnbt = null)
        {
            if (XO == "X")
            {
                XO = "O";
            }
            else
            {
                XO = "X";
            }
            if (lblnbt != null)
            {
                Setlblnbt(lblnbt);
            }
        }

        private void Winner()
        {
            ChangeXO(lblnbt);
            MessageBox.Show($"{XO} برنده!! ", "بازی تمام", MessageBoxButtons.OK);
            Clear();

            if (XO == "X")
            {
                XWins++;
            }
            else
            {
                OWins++;
            }
            ChangeXO();
            lblScore.Text = $"{XWins} : {OWins}";

        }

        private void Clear()
        {
            foreach (Button btn in btns)
            {
                btn.Text = "";
            }
        }

        private int ComputerMove()
        {
            for (int i = 1; i <= 9; i++)
            {
                if (btns[i].Text == "")
                {
                    switch (i)
                    {
                        case 1:
                            {
                                if ((btns[2].Text == btns[3].Text && btns[2].Text == XO) || (btns[5].Text == btns[9].Text && btns[5].Text == XO) || (btns[4].Text == btns[7].Text && btns[7].Text == XO))
                                {
                                    return (i * 11);
                                }

                                break;
                            }
                        case 2:
                            {
                                if ((btns[1].Text == btns[3].Text && btns[1].Text == XO) || (btns[5].Text == btns[8].Text && btns[5].Text == XO))
                                {
                                    return (i * 11);

                                }
                                break;
                            }
                        case 3:
                            {
                                if ((btns[2].Text == btns[1].Text && btns[2].Text == XO) || (btns[6].Text == btns[9].Text && btns[6].Text == XO) || (btns[5].Text == btns[7].Text && btns[7].Text == XO))
                                {
                                    return (i * 11);

                                }
                                break;
                            }
                        case 4:
                            {
                                if ((btns[1].Text == btns[7].Text && btns[1].Text == XO) || (btns[5].Text == btns[6].Text && btns[5].Text == XO))
                                {
                                    return (i * 11);

                                }
                                break;
                            }
                        case 5:
                            {
                                if ((btns[9].Text == btns[1].Text && btns[1].Text == XO) || (btns[7].Text == btns[3].Text && btns[7].Text == XO) || (btns[8].Text == btns[2].Text && btns[2].Text == XO) || (btns[4].Text == btns[6].Text && btns[6].Text == XO))
                                {
                                    return (i * 11);

                                }
                                break;
                            }
                        case 6:
                            {
                                if ((btns[9].Text == btns[3].Text && btns[3].Text == XO) || (btns[5].Text == btns[4].Text && btns[5].Text == XO))
                                {
                                    return (i * 11);

                                }
                                break;
                            }
                        case 7:
                            {
                                if ((btns[4].Text == btns[1].Text && btns[1].Text == XO) || (btns[5].Text == btns[3].Text && btns[5].Text == XO) || (btns[8].Text == btns[9].Text && btns[8].Text == XO))
                                {
                                    return (i * 11);

                                }
                                break;
                            }
                        case 8:
                            {
                                if ((btns[7].Text == btns[9].Text && btns[7].Text == XO) || (btns[5].Text == btns[2].Text && btns[5].Text == XO))
                                {
                                    return (i * 11);

                                }
                                break;
                            }
                        case 9:
                            {
                                if ((btns[6].Text == btns[3].Text && btns[6].Text == XO) || (btns[5].Text == btns[1].Text && btns[5].Text == XO) || (btns[8].Text == btns[7].Text && btns[7].Text == XO))
                                {
                                    return (i * 11);

                                }
                                break;
                            }


                    }
                }
            }

            for (int i = 1; i <= 9; i++)
            {
                if (btns[i].Text == "")
                {
                    ChangeXO();

                    switch (i)
                    {
                        case 1:
                            {
                                if ((btns[2].Text == btns[3].Text && btns[2].Text == XO) || (btns[5].Text == btns[9].Text && btns[5].Text == XO) || (btns[4].Text == btns[7].Text && btns[7].Text == XO))
                                {
                                    ChangeXO();

                                    return (i);
                                }

                                ChangeXO();
                                break;
                            }
                        case 2:
                            {
                                if ((btns[1].Text == btns[3].Text && btns[1].Text == XO) || (btns[5].Text == btns[8].Text && btns[5].Text == XO))
                                {
                                    ChangeXO();

                                    return (i);

                                }
                                ChangeXO();
                                break;
                            }
                        case 3:
                            {
                                if ((btns[2].Text == btns[1].Text && btns[2].Text == XO) || (btns[6].Text == btns[9].Text && btns[6].Text == XO) || (btns[5].Text == btns[7].Text && btns[7].Text == XO))
                                {
                                    ChangeXO();

                                    return (i);

                                }
                                ChangeXO();
                                break;
                            }
                        case 4:
                            {
                                if ((btns[1].Text == btns[7].Text && btns[1].Text == XO) || (btns[5].Text == btns[6].Text && btns[5].Text == XO))
                                {
                                    ChangeXO();

                                    return (i);

                                }
                                ChangeXO();
                                break;
                            }
                        case 5:
                            {
                                if ((btns[9].Text == btns[1].Text && btns[1].Text == XO) || (btns[7].Text == btns[3].Text && btns[7].Text == XO) || (btns[8].Text == btns[2].Text && btns[2].Text == XO) || (btns[4].Text == btns[6].Text && btns[6].Text == XO))
                                {
                                    ChangeXO();

                                    return (i);

                                }
                                ChangeXO();
                                break;
                            }
                        case 6:
                            {
                                if ((btns[9].Text == btns[3].Text && btns[3].Text == XO) || (btns[5].Text == btns[4].Text && btns[5].Text == XO))
                                {
                                    ChangeXO();

                                    return (i);

                                }
                                ChangeXO();
                                break;
                            }
                        case 7:
                            {
                                if ((btns[4].Text == btns[1].Text && btns[1].Text == XO) || (btns[5].Text == btns[3].Text && btns[5].Text == XO) || (btns[8].Text == btns[9].Text && btns[8].Text == XO))
                                {
                                    ChangeXO();

                                    return (i);

                                }
                                ChangeXO();
                                break;
                            }
                        case 8:
                            {
                                if ((btns[7].Text == btns[9].Text && btns[7].Text == XO) || (btns[5].Text == btns[2].Text && btns[5].Text == XO))
                                {
                                    ChangeXO();

                                    return (i);

                                }
                                ChangeXO();
                                break;
                            }
                        case 9:
                            {
                                if ((btns[6].Text == btns[3].Text && btns[6].Text == XO) || (btns[5].Text == btns[1].Text && btns[5].Text == XO) || (btns[8].Text == btns[7].Text && btns[7].Text == XO))
                                {
                                    ChangeXO();

                                    return (i);

                                }
                                ChangeXO();
                                break;
                            }
                    }
                }
            }

            if (btns[5].Text == "")
            {
                return 5;
            }

            foreach (int j in new int[] { 3, 7, 9, 1 })
            {
                if (btns[j].Text == "")
                {
                    return j;
                }
            }
            foreach (int j in new int[] { 4, 8, 2, 6 })
            {
                if (btns[j].Text == "")
                {
                    return j;
                }
            }

            return 0;
        }
        private void MakeComputerMove()
        {
            int ComMove = ComputerMove();
            bool isWin = false;

            if (ComMove > 10)
            {
                ComMove = ComMove / 11;
                isWin = true;
            }

            Insert(btns[ComMove]);

            if (isWin)
            {
                Winner();
            }
            if (IsFull())
            {
                if (MessageBox.Show("پر شد! آیا دوباره بازی میکنید؟", "توجه!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    XO = "X";
                    Clear();
                    Setlblnbt(lblnbt);
                }
            }

        }


        private void btnUL_Click(object sender, EventArgs e)
        {
            bool CanComputerMove = Insert(btnUL);


            if ((btnC.Text == btnDR.Text && btnDR.Text == btnUL.Text) || (btnU.Text == btnUR.Text && btnUR.Text == btnUL.Text) || (btnL.Text == btnDL.Text && btnDL.Text == btnUL.Text))
            {
                Winner();

            }

            if (OName == "Computer" && CanComputerMove)
            {
                MakeComputerMove();
            }
            if (IsFull())
            {
                if (MessageBox.Show("پر شد! آیا دوباره بازی میکنید؟", "توجه!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnRe_Click(sender, e);
                }
            }

        }


        private void btnU_Click(object sender, EventArgs e)
        {
            bool CanComputerMove = Insert(btnU);

            if ((btnC.Text == btnD.Text && btnD.Text == btnU.Text) || (btnUL.Text == btnUR.Text && btnUR.Text == btnU.Text))
            {
                Winner();

            }
            if (OName == "Computer" && CanComputerMove)
            {
                MakeComputerMove();
            }
            if (IsFull())
            {
                if (MessageBox.Show("پر شد! آیا دوباره بازی میکنید؟", "توجه!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnRe_Click(sender, e);
                }
            }
        }

        private void btnUR_Click(object sender, EventArgs e)
        {
            bool CanComputerMove = Insert(btnUR);

            if ((btnC.Text == btnDL.Text && btnDL.Text == btnUR.Text) || (btnU.Text == btnUL.Text && btnUL.Text == btnUR.Text) || (btnR.Text == btnDR.Text && btnDR.Text == btnUR.Text))
            {
                Winner();

            }
            if (OName == "Computer" && CanComputerMove)
            {
                MakeComputerMove();
            }
            if (IsFull())
            {
                if (MessageBox.Show("پر شد! آیا دوباره بازی میکنید؟", "توجه!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnRe_Click(sender, e);
                }
            }
        }

        private void btnL_Click(object sender, EventArgs e)
        {
             bool CanComputerMove = Insert(btnL);

            if ((btnC.Text == btnR.Text && btnR.Text == btnL.Text) || (btnUL.Text == btnDL.Text && btnL.Text == btnDL.Text))
            {
                Winner();

            }
            if (OName == "Computer" && CanComputerMove)
            {
                MakeComputerMove();
            }
            if (IsFull())
            {
                if (MessageBox.Show("پر شد! آیا دوباره بازی میکنید؟", "توجه!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnRe_Click(sender, e);
                }
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            bool CanComputerMove = Insert(btnC);

            if ((btnU.Text == btnD.Text && btnD.Text == btnC.Text) || (btnR.Text == btnL.Text && btnR.Text == btnC.Text) || (btnUL.Text == btnDR.Text && btnDR.Text == btnC.Text) || (btnUR.Text == btnDL.Text && btnDL.Text == btnC.Text))
            {
                Winner();

            }
            if (OName == "Computer" && CanComputerMove)
            {
                MakeComputerMove();
            }
            if (IsFull())
            {
                if (MessageBox.Show("پر شد! آیا دوباره بازی میکنید؟", "توجه!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnRe_Click(sender, e);
                }
            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            bool CanComputerMove = Insert(btnR);

            if ((btnC.Text == btnL.Text && btnR.Text == btnL.Text) || (btnUR.Text == btnDR.Text && btnUR.Text == btnR.Text))
            {
                Winner();

            }
            if (OName == "Computer" && CanComputerMove)
            {
                MakeComputerMove();
            }
            if (IsFull())
            {
                if (MessageBox.Show("پر شد! آیا دوباره بازی میکنید؟", "توجه!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnRe_Click(sender, e);
                }
            }
        }

        private void btnDL_Click(object sender, EventArgs e)
        {
            bool CanComputerMove = Insert(btnDL);

            if ((btnC.Text == btnUR.Text && btnUR.Text == btnDL.Text) || (btnL.Text == btnUL.Text && btnL.Text == btnDL.Text) || (btnD.Text == btnDR.Text && btnD.Text == btnDL.Text))
            {
                Winner();

            }
            if (OName == "Computer" && CanComputerMove)
            {
                MakeComputerMove();
            }
            if (IsFull())
            {
                if (MessageBox.Show("پر شد! آیا دوباره بازی میکنید؟", "توجه!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnRe_Click(sender, e);
                }
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            bool CanComputerMove = Insert(btnD);

            if ((btnC.Text == btnU.Text && btnU.Text == btnD.Text) || (btnDL.Text == btnDR.Text && btnDR.Text == btnD.Text))
            {
                Winner();

            }
            if (OName == "Computer" && CanComputerMove)
            {
                MakeComputerMove();
            }
            if (IsFull())
            {
                if (MessageBox.Show("پر شد! آیا دوباره بازی میکنید؟", "توجه!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnRe_Click(sender, e);
                }
            }
        }

        private void btnDR_Click(object sender, EventArgs e)
        {
            bool CanComputerMove = Insert(btnDR);

            if ((btnC.Text == btnUL.Text && btnUL.Text == btnDR.Text) || (btnR.Text == btnUR.Text && btnUR.Text == btnDR.Text) || (btnD.Text == btnDL.Text && btnDL.Text == btnDR.Text))
            {
                Winner();

            }
            if (OName == "Computer" && CanComputerMove)
            {
                MakeComputerMove();
            }
            if (IsFull())
            {
                if (MessageBox.Show("پر شد! آیا دوباره بازی میکنید؟" , "توجه!!" ,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    btnRe_Click(sender, e);
                }
            }
        }

        private bool IsFull()
        {
            foreach (Button btn in btns)
            {
                if (btn.Text == "")
                {
                    return false;
                }
            }
            return true;
        }


        private void btnRe_Click(object sender, EventArgs e)
        {
            XO = "X";
            Clear();
            Setlblnbt(lblnbt);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            OWins = 0;
            XWins = 0;

            lblScore.Text = $"{XWins} : {OWins}";
        }
    }
}

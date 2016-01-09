/* 
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Crest
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
        /// <summary>
        /// Масив з точками
        /// </summary>
		int [,]PointArea;

        /// <summary>
        /// Признак ходу X або O
        /// </summary>
		bool next = true;

        /// <summary>
        /// Статистика, перемога X, перемога O, кількість нічиїх, всі ігри
        /// </summary>
		int win1 = 0;
        int win2 = 0;
        int drawgame = 0;
        int allgame = 0;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

            PointArea = new int[5, 5] { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
		}

        public void ClearStats()
        {
            win1 = 0;
            win2 = 0;
            drawgame = 0;
            allgame = 0;

            label10.Text = allgame + " ігор";
            label5.Text = win2 + " раз";
            label8.Text = drawgame + " раз";
            label6.Text = win1 + " раз";
        }
		
		public void Restart()
		{
            // Очищення масиву
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    PointArea[i,j] = 0;
                }
            }           

            button1.Text = "";
            button1.Enabled = true;

            button2.Text = "";
            button2.Enabled = true;

            button3.Text = "";
            button3.Enabled = true;

            button4.Text = "";
            button4.Enabled = true;

            button5.Text = "";
            button5.Enabled = true;

            button6.Text = "";
            button6.Enabled = true;

            button7.Text = "";
            button7.Enabled = true;

            button8.Text = "";
            button8.Enabled = true;

            button9.Text = "";
            button9.Enabled = true;

            button10.Text = "";
            button10.Enabled = true;

            button11.Text = "";
            button11.Enabled = true;

            button12.Text = "";
            button12.Enabled = true;

            button13.Text = "";
            button13.Enabled = true;

            button14.Text = "";
            button14.Enabled = true;

            button15.Text = "";
            button15.Enabled = true;

            button16.Text = "";
            button16.Enabled = true;

            button17.Text = "";
            button17.Enabled = true;

            button18.Text = "";
            button18.Enabled = true;

            button19.Text = "";
            button19.Enabled = true;

            button20.Text = "";
            button20.Enabled = true;

            button21.Text = "";
            button21.Enabled = true;

            button22.Text = "";
            button22.Enabled = true;

            button23.Text = "";
            button23.Enabled = true;

            button24.Text = "";
            button24.Enabled = true;

            button25.Text = "";
            button25.Enabled = true;

            label10.Text = allgame + " ігор";
            label5.Text = win2 + " раз";
            label8.Text = drawgame + " раз";
            label6.Text = win1 + " раз";
		}

  
        public void ClickButton(Button button) 
		{
			if(next) {
				button.Text="X";
				button.Enabled=false;
				next=false;
			} else {
				button.Text="0";
				button.Enabled=false;
				next=true;
			}
		}

       
		public bool CheckWin () 
		{            
            // перевірка на нічию
            if (PointArea[0, 0] > 0 && PointArea[0, 1] > 0 && PointArea[0, 2] > 0 && PointArea[0, 3] > 0 && PointArea[0, 4] > 0 &&
                PointArea[1, 0] > 0 && PointArea[1, 1] > 0 && PointArea[1, 2] > 0 && PointArea[1, 3] > 0 && PointArea[1, 4] > 0 &&
                PointArea[2, 0] > 0 && PointArea[2, 1] > 0 && PointArea[2, 2] > 0 && PointArea[2, 3] > 0 && PointArea[2, 4] > 0 &&
                PointArea[3, 0] > 0 && PointArea[3, 1] > 0 && PointArea[3, 2] > 0 && PointArea[3, 3] > 0 && PointArea[3, 4] > 0 &&
                PointArea[4, 0] > 0 && PointArea[4, 1] > 0 && PointArea[4, 2] > 0 && PointArea[4, 3] > 0 && PointArea[4, 4] > 0)
            {

                MessageBox.Show("Гра закінчилась в нічию");
                drawgame += 1;
                allgame += 1;

                Restart();
                return false;
            }
            // перевірка на перемогу
            /////////////////////////////////
            //11111 00000 00000 00000 00000//
            //00000 11111 00000 00000 00000//
            //00000 00000 11111 00000 00000//
            //00000 00000 00000 11111 00000//
            //00000 00000 00000 00000 11111//
            /////////////////////////////////
            if (((PointArea[0, 0] == PointArea[0, 1] && PointArea[0, 1] == PointArea[0, 2] && PointArea[0, 2] == PointArea[0, 3] && PointArea[0, 3] == PointArea[0, 4])
                && (PointArea[0, 0] > 0
                && PointArea[0, 1] > 0
                && PointArea[0, 2] > 0
                && PointArea[0, 3] > 0
                && PointArea[0, 4] > 0))
               ||
               ((PointArea[1, 0] == PointArea[1, 1] && PointArea[1, 1] == PointArea[1, 2] && PointArea[1, 2] == PointArea[1, 3] && PointArea[1, 3] == PointArea[1, 4])
                && (PointArea[1, 0] > 0
                && PointArea[1, 1] > 0
                && PointArea[1, 2] > 0
                && PointArea[1, 3] > 0
                && PointArea[1, 4] > 0))
			   ||
               ((PointArea[2, 0] == PointArea[2, 1] && PointArea[2, 1] == PointArea[2, 2] && PointArea[2, 2] == PointArea[2, 3] && PointArea[2, 3] == PointArea[2, 4])
                && (PointArea[2, 0] > 0
                && PointArea[2, 1] > 0
                && PointArea[2, 2] > 0
                && PointArea[2, 3] > 0
                && PointArea[2, 4] > 0))
                ||
               ((PointArea[3, 0] == PointArea[3, 1] && PointArea[3, 1] == PointArea[3, 2] && PointArea[3, 2] == PointArea[3, 3] && PointArea[3, 3] == PointArea[3, 4])
                && (PointArea[3, 0] > 0
                && PointArea[3, 1] > 0
                && PointArea[3, 2] > 0
                && PointArea[3, 3] > 0
                && PointArea[3, 4] > 0))
                ||
               ((PointArea[4, 0] == PointArea[4, 1] && PointArea[4, 1] == PointArea[4, 2] && PointArea[4, 2] == PointArea[4, 3] && PointArea[4, 3] == PointArea[4, 4])
                && (PointArea[4, 0] > 0
                && PointArea[4, 1] > 0
                && PointArea[4, 2] > 0
                && PointArea[4, 3] > 0
                && PointArea[4, 4] > 0))
				/////////////////////////////////
                //10000 01000 00100 00010 00001//
                //10000 01000 00100 00010 00001//
                //10000 01000 00100 00010 00001//
                //10000 01000 00100 00010 00001//
                //10000 01000 00100 00010 00001//
                /////////////////////////////////
			   ||                
               ((PointArea[0, 0] == PointArea[1, 0] && PointArea[1, 0] == PointArea[2, 0] && PointArea[2, 0] == PointArea[3, 0] && PointArea[3, 0] == PointArea[4, 0])
                && (PointArea[0, 0] > 0
                && PointArea[1, 0] > 0
                && PointArea[2, 0] > 0
                && PointArea[3, 0] > 0
                && PointArea[4, 0] > 0))
			   ||
               ((PointArea[0, 1] == PointArea[1, 1] && PointArea[1, 1] == PointArea[2, 1] && PointArea[2, 1] == PointArea[3, 1] && PointArea[3, 1] == PointArea[4, 1])
                && (PointArea[0, 1] > 0
                && PointArea[1, 1] > 0
                && PointArea[2, 1] > 0
                && PointArea[3, 1] > 0
                && PointArea[4, 1] > 0))
			   ||
               ((PointArea[0, 2] == PointArea[1, 2] && PointArea[1, 2] == PointArea[2, 2] && PointArea[2, 2] == PointArea[3, 2] && PointArea[3, 2] == PointArea[4, 2])
                && (PointArea[0, 2] > 0
                && PointArea[1, 2] > 0
                && PointArea[2, 2] > 0
                && PointArea[3, 2] > 0
                && PointArea[4, 2] > 0))
                ||
               ((PointArea[0, 3] == PointArea[1, 3] && PointArea[1, 3] == PointArea[2, 3] && PointArea[2, 3] == PointArea[3, 3] && PointArea[3, 3] == PointArea[4, 3])
                && (PointArea[0, 3] > 0
                && PointArea[1, 3] > 0
                && PointArea[2, 3] > 0
                && PointArea[3, 3] > 0
                && PointArea[4, 3] > 0))
                ||
               ((PointArea[0, 4] == PointArea[1, 4] && PointArea[1, 4] == PointArea[2, 4] && PointArea[2, 4] == PointArea[3, 4] && PointArea[3, 4] == PointArea[4, 4])
                && (PointArea[0, 4] > 0
                && PointArea[1, 4] > 0
                && PointArea[2, 4] > 0
                && PointArea[3, 4] > 0
                && PointArea[4, 4] > 0))
					
			   
                /////////
                //10001//
                //01010//
                //00100// 
                //01010//
                //10001//
                /////////
                ||
               ((PointArea[0, 0] == PointArea[1, 1] && PointArea[1, 1] == PointArea[2, 2] && PointArea[2, 2] == PointArea[3, 3] && PointArea[3, 3] == PointArea[4, 4])
                && (PointArea[0, 0] > 0
                && PointArea[1, 1] > 0
                && PointArea[2, 2] > 0
                && PointArea[3, 3] > 0
                && PointArea[4, 4] > 0))
			   ||
               ((PointArea[0, 4] == PointArea[1, 3] && PointArea[1, 3] == PointArea[2, 2] && PointArea[2, 2] == PointArea[3, 1] && PointArea[3, 1] == PointArea[4, 0])
                && (PointArea[0, 4] > 0
                && PointArea[1, 3] > 0
                && PointArea[2, 2] > 0
                && PointArea[3, 1] > 0
                && PointArea[4, 0] > 0)))
			{
                if (next)
                {
                    MessageBox.Show("Переміг 0");
                    win1 += 1;
                }
                else
                {
                    MessageBox.Show("Переміг X");
                    win2 += 1;
                }
                allgame += 1;
				Restart();
			}

            return true;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			ClickButton(button1);

			if(next) 
            {
				PointArea[0,0]=1;
			} 
            else 
            {
			    PointArea[0,0]=2;	
			}

			CheckWin();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			ClickButton(button2);

			if(next) 
            {
			    PointArea[0,1]=1;
			} 
            else 
            {
			    PointArea[0,1]=2;	
			}

			CheckWin();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			ClickButton(button3);

			if(next) 
            {
				PointArea[0,2]=1;
			} 
            else 
            {
				PointArea[0,2]=2;	
			}

			CheckWin();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			ClickButton(button4);

			if(next) 
            {
				PointArea[1,0]=1;
            } 
            else 
            {
				PointArea[1,0]=2;
			}

			CheckWin();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			ClickButton(button5);

			if(next) 
            {
				PointArea[1,1]=1;
            } 
            else 
            {
				PointArea[1,1]=2;
			}

			CheckWin();
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			ClickButton(button6);

			if(next) 
            {
				PointArea[1,2]=1;
			} 
            else 
            {
				PointArea[1,2]=2;
			}

			CheckWin();
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			ClickButton(button7);
			
            if(next) 
            {
				PointArea[2,0]=1;
			} 
            else 
            {
				PointArea[2,0]=2;
			}

			CheckWin();
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			ClickButton(button8);

			if(next) 
            {
				PointArea[2,1]=1;
			} else {
				PointArea[2,1]=2;
			}

			CheckWin();
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			ClickButton(button9);

			if(next) 
            {
				PointArea[2,2]=1;
			} 
            else 
            {
				PointArea[2,2]=2;
			}

			CheckWin();
		}

        ///////////////////////////////////////////
        private void button10_Click(object sender, EventArgs e)
        {
            ClickButton(button10);

            if (next)
            {
                PointArea[0, 3] = 1;
            }
            else
            {
                PointArea[0, 3] = 2;
            }

            CheckWin();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            ClickButton(button13);

            if (next)
            {
                PointArea[0, 4] = 1;
            }
            else
            {
                PointArea[0, 4] = 2;
            }

            CheckWin();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ClickButton(button11);

            if (next)
            {
                PointArea[1, 3] = 1;
            }
            else
            {
                PointArea[1, 3] = 2;
            }

            CheckWin();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ClickButton(button14);

            if (next)
            {
                PointArea[1, 4] = 1;
            }
            else
            {
                PointArea[1, 4] = 2;
            }

            CheckWin();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ClickButton(button12);

            if (next)
            {
                PointArea[2, 3] = 1;
            }
            else
            {
                PointArea[2, 3] = 2;
            }

            CheckWin();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ClickButton(button15);

            if (next)
            {
                PointArea[2, 4] = 1;
            }
            else
            {
                PointArea[2, 4] = 2;
            }

            CheckWin();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ClickButton(button20);

            if (next)
            {
                PointArea[3, 0] = 1;
            }
            else
            {
                PointArea[3, 0] = 2;
            }

            CheckWin();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ClickButton(button19);

            if (next)
            {
                PointArea[3, 1] = 1;
            }
            else
            {
                PointArea[3, 1] = 2;
            }

            CheckWin();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ClickButton(button18);

            if (next)
            {
                PointArea[3, 2] = 1;
            }
            else
            {
                PointArea[3, 2] = 2;
            }

            CheckWin();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ClickButton(button17);

            if (next)
            {
                PointArea[3, 3] = 1;
            }
            else
            {
                PointArea[3, 3] = 2;
            }

            CheckWin();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ClickButton(button16);

            if (next)
            {
                PointArea[3, 4] = 1;
            }
            else
            {
                PointArea[3, 4] = 2;
            }

            CheckWin();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ClickButton(button21);

            if (next)
            {
                PointArea[4, 0] = 1;
            }
            else
            {
                PointArea[4, 0] = 2;
            }

            CheckWin();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ClickButton(button22);

            if (next)
            {
                PointArea[4, 1] = 1;
            }
            else
            {
                PointArea[4, 1] = 2;
            }

            CheckWin();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ClickButton(button23);

            if (next)
            {
                PointArea[4, 2] = 1;
            }
            else
            {
                PointArea[4, 2] = 2;
            }

            CheckWin();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            ClickButton(button24);

            if (next)
            {
                PointArea[4, 3] = 1;
            }
            else
            {
                PointArea[4, 3] = 2;
            }

            CheckWin();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            ClickButton(button25);

            if (next)
            {
                PointArea[4, 4] = 1;
            }
            else
            {
                PointArea[4, 4] = 2;
            }

            CheckWin();
        }
        //////////////////////////////////////////

        // Всі ігри
        private void label10_Click(object sender, EventArgs e)
        {
            label10.Text = allgame + " ігор";
        }

        // Перемоги X
        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = win1 + " раз";
        }

        // Нічії
        private void label8_Click(object sender, EventArgs e)
        {
            label8.Text = drawgame + " раз";
        }

        // Перемоги 0
        private void label6_Click(object sender, EventArgs e)
        {
            label6.Text = win2 + " раз";
        }


        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void ClearStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearStats();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 About = new AboutBox1();
            About.Show();
        }

        private void играToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayintarlasi
{
    public partial class mayinFrm : Form
    {
        int[,] mayinlar;
        int boyut;
        Button[,] bt;
        public mayinFrm()
        {
            InitializeComponent();
        }

        private void oyunbtn_Click(object sender, EventArgs e)
        {
            Button basilan = (Button)sender;
            String[] koord = basilan.Name.Split('-');
            int x = int.Parse(koord[0]);
            int y = int.Parse(koord[1]);
            if (mayinlar[x,y]==1)
            {                
                MessageBox.Show("mayına bastınız");

                for (int i = 0; i < boyut; i++)
                {
                    for (int j = 0; j < boyut; j++)
                    {
                        if (mayinlar[i, j] == 1)
                        {
                            bt[i, j].Text = "1";                            
                        }                        
                        bt[i, j].Enabled = false;                       
                    }
                }
            }
            else
            {
                bt[x, y].Enabled = false;
                int msayi = 0;
                if((y+1)!=boyut)
                {
                   if(mayinlar[x,y+1]==1)
                    {
                        msayi++;
                    }
                }
                if (y != 0)
                {
                    if (mayinlar[x, y - 1] == 1)
                    {
                        msayi++;
                    }
                }
                if ((x + 1) != boyut)
                {
                    if (mayinlar[x+1, y] == 1)
                    {
                        msayi++;
                    }
                }
                if (x != 0)
                {
                    if (mayinlar[x-1, y] == 1)
                    {
                        msayi++;
                    }
                }
                bt[x, y].Text = msayi.ToString();
            }
        }
            private void baslabtn_Click(object sender, EventArgs e)
        {
            baslabtn.Enabled = false;
            oyunalanigrp.Controls.Clear();
            int rsayi = 0;
            Random r = new Random();
            if(kolayrb.Checked)
            {
                rsayi = r.Next(8);
                boyut = 3;
                mayinlar = new int[boyut, boyut];
                for (int i = 0; i < 1; i++)
                {
                    mayinlar[r.Next(2), r.Next(2)] = 1;
                }
                bt = new Button[boyut, boyut];
                
                for(int i=0;i<boyut;i++)
                {
                    for(int j=0;j<boyut;j++)
                    {
                        bt[i, j] = new Button();
                        bt[i, j].Width = 40;
                        bt[i, j].Height = 40;
                        bt[i, j].Left = oyunalanigrp.Width/2-(bt[i, j].Width*boyut/2) + j * bt[i, j].Width;
                        bt[i, j].Top= oyunalanigrp.Height / 2 - (bt[i, j].Height * boyut / 2) + i * bt[i, j].Height;
                        bt[i, j].Parent = oyunalanigrp;
                        bt[i, j].Click += new EventHandler(oyunbtn_Click);
                        bt[i, j].Name = i + "-" + j;
                    }
                }
            }
            if (ortarb.Checked)
            {
                boyut = 4;                
                mayinlar = new int[boyut, boyut];
                for (int i = 0; i < boyut; i++)
                {
                    mayinlar[r.Next(3), r.Next(3)] = 1;
                }                              
               
                bt = new Button[boyut, boyut];
                for (int i = 0; i < boyut; i++)
                {
                    for (int j = 0; j < boyut; j++)
                    {
                        bt[i, j] = new Button();
                        bt[i, j].Width = 40;
                        bt[i, j].Height = 40;
                        bt[i, j].Left = oyunalanigrp.Width / 2 - (bt[i, j].Width * boyut / 2) + j * bt[i, j].Width;
                        bt[i, j].Top = oyunalanigrp.Height / 2 - (bt[i, j].Height * boyut / 2) + i * bt[i, j].Height;
                        bt[i, j].Parent = oyunalanigrp;
                        bt[i, j].Click += new EventHandler(oyunbtn_Click);
                        bt[i, j].Name = i + "-" + j;
                    }
                }
            }
            if (zorrb.Checked)
            {
                boyut = 5;
                bt = new Button[boyut, boyut];
                mayinlar = new int[boyut, boyut];
                for (int i = 0; i < 8; i++)
                {
                    mayinlar[r.Next(4), r.Next(4)] = 1;
                }
                for (int i = 0; i < boyut; i++)
                {
                    for (int j = 0; j < boyut; j++)
                    {
                        bt[i, j] = new Button();
                        bt[i, j].Width = 40;
                        bt[i, j].Height = 40;
                        bt[i, j].Left = oyunalanigrp.Width / 2 - (bt[i, j].Width * boyut / 2) + j * bt[i, j].Width;
                        bt[i, j].Top = oyunalanigrp.Height / 2 - (bt[i, j].Height * boyut / 2) + i * bt[i, j].Height;
                        bt[i, j].Parent = oyunalanigrp;
                        bt[i, j].Click += new EventHandler(oyunbtn_Click);
                        bt[i, j].Name = i + "-" + j;
                    }
                }
            }
        }

        private void sifirlabtn_Click(object sender, EventArgs e)
        {
            baslabtn.Enabled = true;
            oyunalanigrp.Controls.Clear();
        }
    }
}

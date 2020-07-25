using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ROBOTIS;

namespace Falcon_0_0
{
    public partial class Form1 : Form
    {
        public const int DEFAULT_PORTNUM = 20;
        public const int DEFAULT_BAUDRATE = 1;
        public const int auxR1 = 4096;
        public const int aux2R1 = 1296;

        public Form1()
        {
            InitializeComponent();
            dynamixel.dxl_initialize(DEFAULT_PORTNUM, DEFAULT_BAUDRATE);

        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }


        public static void p1()
        {
            int j = 0;

            for (int i = 2048; i < 2349; i++)
            {
                dynamixel.dxl_write_word(14, 30, i);
                dynamixel.dxl_write_word(16, 30, i);
                dynamixel.dxl_write_word(19, 30, i);
                j = auxR1 - i;
                dynamixel.dxl_write_word(18, 30, j);
                dynamixel.dxl_write_word(20, 30, j);
                dynamixel.dxl_write_word(13, 30, j);
                dynamixel.dxl_write_word(15, 30, j);

            }

            j = 0;

            for (int i = 1748; i < 2049; i++)
            {
                dynamixel.dxl_write_word(18, 30, i);
                dynamixel.dxl_write_word(20, 30, i);
                dynamixel.dxl_write_word(13, 30, i);
                dynamixel.dxl_write_word(15, 30, i);
                j = auxR1 - i;
                dynamixel.dxl_write_word(14, 30, j);
                dynamixel.dxl_write_word(16, 30, j);
                dynamixel.dxl_write_word(19, 30, j);
            }
        }


        public static void aux_()
        {
            int cont = 0;
            int pos_obj =150;
            int h = 2048;
            int i = 2048;
            int j = 2048;
            int aux = 0;
            int k = 2048;

            while (cont < pos_obj)
            {
                cont++;
                h --;
                i ++;
                j += 2;              
                dynamixel.dxl_write_word(21, 30, k);
                dynamixel.dxl_write_word(13, 30, h);
                dynamixel.dxl_write_word(19, 30, i);
                dynamixel.dxl_write_word(15, 30, j);                
            }


            cont = 0;

            while (cont < pos_obj)
            {
                cont++;
                h ++;
                i --;
                j -= 2;              
                dynamixel.dxl_write_word(21, 30, k);
                dynamixel.dxl_write_word(21, 30, 2048);
                dynamixel.dxl_write_word(13, 30, h);
                dynamixel.dxl_write_word(19, 30, i);
                dynamixel.dxl_write_word(15, 30, j);
            }
        }

        public static void r1IZ()
        {
            int j = 0;

            for (int i = 2048; i < 2249; i++)
            {
                
                dynamixel.dxl_write_word(15, 30, i);
                dynamixel.dxl_write_word(19, 30, i);
                j = auxR1 - i;
                dynamixel.dxl_write_word(13, 30, j);
                
                
            }

            j = 0;

            for (int i = 1848; i < 2049; i++)
            {                
                dynamixel.dxl_write_word(13, 30, i);
                j = auxR1 - i;
                dynamixel.dxl_write_word(15, 30, j);
                dynamixel.dxl_write_word(19, 30, j);
            }

        }


        public static void r1DE()
        {
            int j = 0;

            for (int i = 2048; i < 2249; i++)
            {

                

                dynamixel.dxl_write_word(19, 30, i);                
                j = auxR1 - i;
                dynamixel.dxl_write_word(13, 30, j);
                dynamixel.dxl_write_word(15, 30, j);

                

            }

            j = 0;

            for (int i = 1848; i < 2049; i++)
            {
                dynamixel.dxl_write_word(13, 30, i);
                dynamixel.dxl_write_word(15, 30, i);
                j = auxR1 - i;
                dynamixel.dxl_write_word(19, 30, j);               
            }

        }

        public static void pan_till()
        {

            for (int i = 2048; i <= 2298; i++)
            {
                dynamixel.dxl_write_word(1,30,i);
                dynamixel.dxl_write_word(2, 30, i);
            }

            for (int i = 2298; i <= 2298; i++)
            {
                dynamixel.dxl_write_word(1, 30, i);
                dynamixel.dxl_write_word(2, 30, i);
            }


        }

        public static void r2()
        {
            for (int i = 2048; i < 2200; i++)
            {
                dynamixel.dxl_write_word(20,30,i);
                Thread.Sleep(20);
            }

            for (int i = 2200; i > 2047; i--)
            {
                dynamixel.dxl_write_word(20, 30, i);
                Thread.Sleep(20);
            }
        }


        public void Iniciar()
        {          
            for (int i =1 ; i <= 22; i++)
            {
                    dynamixel.dxl_write_word(i, 30, 2048);                
            }



        }

        private void btnRutina_Click(object sender, EventArgs e)
        {
            //r1DE();
            r1IZ();
        }

        private void btnRutina2_Click(object sender, EventArgs e)
        {
            aux_();
        }

        private void tmFBDE_Tick(object sender, EventArgs e)
        {
            r1DE();
        }

        private void tmFBIZ_Tick(object sender, EventArgs e)
        {
            r1IZ();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //tmFBIZ.Enabled = false;
            //tmFBDE.Enabled = false;
        }

        private void btnStarR1_Click(object sender, EventArgs e)
        {
            //tmFBIZ.Enabled = true;
           // tmFBDE.Enabled = true;
        }

        private void btnStopR1_Click(object sender, EventArgs e)
        {
            //tmFBIZ.Enabled = false;
           // tmFBDE.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p1();
        }

        private void btnPanTill_Click(object sender, EventArgs e)
        {
            pan_till();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pan_till();
        }
    }
}

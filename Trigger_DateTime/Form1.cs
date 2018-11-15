using Mulaolao.Class;
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

namespace Trigger_DateTime
{
    public partial class Trigger_Date : Form
    {
        public Trigger_Date ( )
        {
            InitializeComponent( );
        }

        Trigger_DateBll.Bll.TriggerBll _bll = new Trigger_DateBll.Bll.TriggerBll( );
        int temp = 0;
        int pos = -1;
        int i = 0;
        
        private void Trigger_Date_Load ( object sender ,EventArgs e )
        {
           
        }
        private void textBox1_KeyPress ( object sender ,KeyPressEventArgs e )
        {
            DateDay.intgra( e );
        }
        private void button1_Click ( object sender ,EventArgs e )
        {         
            temp = Convert.ToInt32( textBox1.Text );
            i = 0;
            pos = 1;
            this.WindowState = FormWindowState.Minimized;

        }
        private void button2_Click ( object sender ,EventArgs e )
        {
            pos = 0;
        }

        void update (  )
        {
            DataTable sgmraa = _bll.GetDataTable( );
            if ( sgmraa != null && sgmraa.Rows.Count > 0 )
            {
                for ( int i = 0 ; i < sgmraa.Rows.Count ; i++ )
                {
                    DataTable dea = _bll.GetDataTableDea( sgmraa.Rows[i]["RAA015"].ToString( ) );
                    if ( dea != null && dea.Rows.Count > 0 )
                    {
                        for ( int k = 0 ; k < dea.Rows.Count ; k++ )
                        {
                            _bll.Update( dea.Rows[k]["DEA961"].ToString( ) ,sgmraa.Rows[i]["RAA015"].ToString( ) );
                        }
                    }
                }
            }
        }
        private void button3_Click ( object sender ,EventArgs e )
        {
            this.Close( );
        }

        private void timer1_Tick ( object sender ,EventArgs e )
        {
            if ( pos == 1 )
            {
                i++;
                if ( i == temp )
                {
                    i = 0;
                    update( );
                }
            }
        }
    }
}

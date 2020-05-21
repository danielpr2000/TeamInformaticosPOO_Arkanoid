using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Form1 : Form
    {
    
        enum Position
        {
            Left,
            Right, 
            Center
        }
        
        enum Direction_x
        {
        Right,
        Left
        }

        enum Direction_y
        { 
            Up,
            Down
        }

        private int _x_Platform;
        private int _x_Ball;
        private int _y_Ball;
        private int _x_Platform_Intervl_R;
        private int _x_Platform_Intervl_L;
        private Position _ObjPosition;
        private Direction_x _BallDirection_x;
        private Direction_y _BallDirection_y;
        
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            _x_Platform = (this.Width/2) - 50;
            _x_Ball = (this.Width / 2) - 10;
            _BallDirection_x = Direction_x.Left;
            _BallDirection_y = Direction_y.Up;
            _x_Platform_Intervl_L = _x_Platform;
            _x_Platform_Intervl_R = _x_Platform + 115;
            _y_Ball = 540 - 10;
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {   //
            // Platform
            e.Graphics.FillRectangle(Brushes.DarkGreen, _x_Platform, 540, 100, 10);
            //
            //
            //
            //Ball
            e.Graphics.DrawImage(new Bitmap("242px-Diego_Nuñez_Berrospi.jpg"), _x_Ball, _y_Ball, 10,10 );
            //
            //
        }


        private void tmrMoving_Tick(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            Invalidate();
            tmrMoving.Interval = 1;
            

            if (_ObjPosition == Position.Left)
            {
                _x_Platform -= 50;
                
                _x_Platform_Intervl_L = _x_Platform - 10;
                _x_Platform_Intervl_R = _x_Platform + 120;
                
                _ObjPosition = Position.Center;
            }
            else if (_ObjPosition == Position.Right) 
            {
                _x_Platform += 50;
                
                _x_Platform_Intervl_L = _x_Platform - 10;
                _x_Platform_Intervl_R = _x_Platform + 120;
                
                _ObjPosition = Position.Center;
            }
            else if (_ObjPosition == Position.Center) 
            {
                if (_x_Platform <= 0 )
                {
                    _x_Platform = 0;
                    _ObjPosition = Position.Center;
                }
                else if (_x_Platform >= (this.Width - 115) )
                {
                    _x_Platform = (this.Width - 115 );
                    _ObjPosition = Position.Center;
                }
            }
            

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                _ObjPosition = Position.Left;

            }
            else if (e.KeyCode == Keys.Right)
            {
                _ObjPosition = Position.Right;
            }
        }


        private void tmrBall_Tick(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            Invalidate();
            tmrBall.Interval = 1;
            //
            //
            if (_BallDirection_x == Direction_x.Right && _BallDirection_y == Direction_y.Up)
            {
                _x_Ball += 10;
                _y_Ball -= 10;
                
                
                if (_x_Ball >= this.Width - 10 && _BallDirection_y == Direction_y.Up)
                {
                    _BallDirection_x = Direction_x.Left;
                }
                else if (_BallDirection_x == Direction_x.Right && _y_Ball <= 0)
                {
                    _BallDirection_y = Direction_y.Down;
                }
                
            }
            //
            //
            if (_BallDirection_x == Direction_x.Right && _BallDirection_y == Direction_y.Down)
            {
                _x_Ball += 10;
                _y_Ball += 10;
                
                if (_x_Ball >= this.Width - 10 && _BallDirection_y == Direction_y.Down)
                {
                    _BallDirection_x = Direction_x.Left;
                }
                else if (_BallDirection_x == Direction_x.Right && _x_Ball >= _x_Platform_Intervl_L && _x_Ball <= _x_Platform_Intervl_R &&  _y_Ball > 539 && _y_Ball < 550 )//WorkSpace
                {
                    _BallDirection_y = Direction_y.Up;
                }
                else if (_BallDirection_x == Direction_x.Right && (_x_Ball < _x_Platform_Intervl_L || _x_Ball > _x_Platform_Intervl_R) && _y_Ball > 555)//WorkSpace
                {
                    _x_Platform = (this.Width/2) - 50;
                    _x_Ball = (this.Width / 2) - 10;
                    _BallDirection_y = Direction_y.Up;
                    if (_BallDirection_x == Direction_x.Right)
                    {
                        _BallDirection_x = Direction_x.Left;
                    }
                    else
                    {
                        _BallDirection_x = Direction_x.Right;
                    }
                }
                
                
            }
            //
            //
            // 
            //
            if (_BallDirection_x == Direction_x.Left && _BallDirection_y == Direction_y.Up)
            {
                _x_Ball -= 10;
                _y_Ball -= 10;
                
                if (_x_Ball <= 0 && _BallDirection_y == Direction_y.Up)
                {
                    _BallDirection_x = Direction_x.Right;
                }
                else if (_BallDirection_x == Direction_x.Left && _y_Ball <= 0)
                {
                    _BallDirection_y = Direction_y.Down;
                }
                
            }
            //
            //
            if (_BallDirection_x == Direction_x.Left && _BallDirection_y == Direction_y.Down)
            {
                _x_Ball -= 10;
                _y_Ball += 10;
                
                if (_x_Ball <= 0 && _BallDirection_y == Direction_y.Down)
                {
                    _BallDirection_x = Direction_x.Right;
                }
                else if (_BallDirection_x == Direction_x.Left && _x_Ball >= _x_Platform_Intervl_L && _x_Ball <= _x_Platform_Intervl_R && _y_Ball > 539 && _y_Ball < 550 ) //WorkSpace
                {
                    _BallDirection_y = Direction_y.Up;
                }
                else if (_BallDirection_x == Direction_x.Left && (_x_Ball < _x_Platform_Intervl_L || _x_Ball > _x_Platform_Intervl_R) && _y_Ball > 555) //WorkSpace
                {
                    _x_Platform = (this.Width/2) - 50;
                    _x_Ball = (this.Width / 2) - 10;
                    _BallDirection_y = Direction_y.Up;

                    if (_BallDirection_x == Direction_x.Right)
                    {
                        _BallDirection_x = Direction_x.Left;
                    }
                    else
                    {
                        _BallDirection_x = Direction_x.Right;
                    }
                }
                
            }
            //
            //
            
            
        }
        
        
    }
}
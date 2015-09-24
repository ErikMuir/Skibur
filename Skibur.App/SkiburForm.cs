using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Skibur.PuzzleLogic;

namespace Skibur.App
{
    public partial class SkiburForm : Form
    {
        #region -- Private Members --

        private User _user;
        private string _fileName = "";

        #endregion

        #region -- Constructors --

        public SkiburForm()
        {
            InitializeComponent();
            InitializeUser();
        }

        #endregion

        #region -- General Methods --

        private void InitializeUser()
        {
            _user = new User();
            RefreshDisplay();
        }

        private void InitializeCube(Cube cube)
        {
            _user.Cube = new Cube(cube);
            RefreshDisplay();
        }

        private void RefreshDisplay()
        {
            tblUp.Refresh();
            tblDown.Refresh();
            tblLeft.Refresh();
            tblRight.Refresh();
            tblFront.Refresh();
            tblBack.Refresh();
            ButtonsRefresh();
            lblTurnCount.Text = string.Format("Turn Count: {0}", _user.Cube.TurnCount);
            lblElapsedTime.Text = string.Format("Elapsed Time: {0}", NiceTime(_user.Cube.ElapsedTime));
            btnUndo.Enabled = (_user.Current > 0);
            btnRedo.Enabled = (_user.Current < _user.Commands.Count);
        }

        private void CubeIsSolved()
        {
            timer1.Stop();
            MessageBox.Show(
                string.Format(
                    "Congratulations! You solved the puzzle in {0} with {1} turns!",
                    NiceTime(_user.Cube.ElapsedTime),
                    _user.Cube.TurnCount
                )
            );
        }

        private void LoadCube()
        {
            var newCube = new Cube();
            var cubeString = File.ReadAllText(_fileName).Split('|');
            var colors = cubeString[0].ToCharArray();

            try
            {
                newCube.TurnCount = int.Parse(cubeString[1]);
                newCube.ElapsedTime = int.Parse(cubeString[2]);
            }
            catch (Exception)
            {
                throw new IOException();
            }

            var i = 0;

            for (var x = 0; x < 3; x++)
            {
                for (var y = 0; y < 3; y++)
                {
                    for (var z = 0; z < 3; z++)
                    {
                        var cubie =
                            newCube.Cubies.FirstOrDefault(
                                c => c.XSlice.Index == x && c.YSlice.Index == y && c.ZSlice.Index == z);

                        if (cubie == null)
                            throw new IOException();

                        cubie.XColor = newCube.FaceColors.FirstOrDefault(fc => fc.Symbol == colors[i]);
                        i++;
                        cubie.YColor = newCube.FaceColors.FirstOrDefault(fc => fc.Symbol == colors[i]);
                        i++;
                        cubie.ZColor = newCube.FaceColors.FirstOrDefault(fc => fc.Symbol == colors[i]);
                        i++;
                    }
                }
            }

            InitializeCube(newCube);
        }

        private static string NiceTime(int time)
        {
            var hours = (time / 3600);
            var minutes = ((time / 60) % 60);
            var seconds = (time % 60);

            return hours >= 1
                ? string.Format("{0}:{1:00}:{2:00}", hours, minutes, seconds)
                : string.Format("{0}:{1:00}", minutes, seconds);
        }

        private void ButtonsRefresh()
        {
            btnL1Turn.BackColor = _user.Cube.XColors[0].Color;
            btnL2Turn.BackColor = _user.Cube.XColors[0].Color;
            btnL3Turn.BackColor = _user.Cube.XColors[0].Color;
            btnR1Turn.BackColor = _user.Cube.XColors[2].Color;
            btnR2Turn.BackColor = _user.Cube.XColors[2].Color;
            btnR3Turn.BackColor = _user.Cube.XColors[2].Color;
            btnU1Turn.BackColor = _user.Cube.YColors[0].Color;
            btnU2Turn.BackColor = _user.Cube.YColors[0].Color;
            btnU3Turn.BackColor = _user.Cube.YColors[0].Color;
            btnD1Turn.BackColor = _user.Cube.YColors[2].Color;
            btnD2Turn.BackColor = _user.Cube.YColors[2].Color;
            btnD3Turn.BackColor = _user.Cube.YColors[2].Color;
            btnF1Turn.BackColor = _user.Cube.ZColors[0].Color;
            btnF2Turn.BackColor = _user.Cube.ZColors[0].Color;
            btnF3Turn.BackColor = _user.Cube.ZColors[0].Color;
            btnB1Turn.BackColor = _user.Cube.ZColors[2].Color;
            btnB2Turn.BackColor = _user.Cube.ZColors[2].Color;
            btnB3Turn.BackColor = _user.Cube.ZColors[2].Color;
            btnX1Rotate.BackColor = _user.Cube.XColors[2].Color;
            btnX2Rotate.BackColor = _user.Cube.XColors[2].Color;
            btnX3Rotate.BackColor = _user.Cube.XColors[2].Color;
            btnY1Rotate.BackColor = _user.Cube.YColors[0].Color;
            btnY2Rotate.BackColor = _user.Cube.YColors[0].Color;
            btnY3Rotate.BackColor = _user.Cube.YColors[0].Color;
            btnZ1Rotate.BackColor = _user.Cube.ZColors[0].Color;
            btnZ2Rotate.BackColor = _user.Cube.ZColors[0].Color;
            btnZ3Rotate.BackColor = _user.Cube.ZColors[0].Color;
        }

        private void CubiePaint(Slice slice, TableLayoutCellPaintEventArgs cell)
        {
            int x, y, z;
            Axis axis = slice.Axis;

            switch (axis)
            {
                case Axis.X:
                    x = slice.Index;
                    y = cell.Row;
                    z = slice.Index == 0 ? ((cell.Column * -1) + 2) : cell.Column;
                    break;
                case Axis.Y:
                    x = cell.Column;
                    y = slice.Index;
                    z = slice.Index == 0 ? ((cell.Row * -1) + 2) : cell.Row;
                    break;
                case Axis.Z:
                    x = slice.Index == 0 ? cell.Column : ((cell.Column * -1) + 2);
                    y = cell.Row;
                    z = slice.Index;
                    break;
                default:
                    x = 1;
                    y = 1;
                    z = 1;
                    break;
            }

            cell.Graphics.FillRectangle(new SolidBrush(_user.Cube.GetColor(x, y, z, axis)), cell.CellBounds);
        }

        #endregion

        #region -- Event Handler Methods --

        private void btnNew_Click(object sender, EventArgs e)
        {
            _user.Reset();
            InitializeCube(new Cube());
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_fileName != "")
                File.WriteAllText(_fileName, _user.Cube.ToString());
            else
                saveFileDialog1.ShowDialog();
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            _user.Undo();
            RefreshDisplay();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            _user.Redo();
            RefreshDisplay();
        }

        private void btnScramble_Click(object sender, EventArgs e)
        {
            _user.Reset();
            _user.Cube.Scramble();
            timer1.Start();
            RefreshDisplay();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _user.Reset();
            timer1.Stop();
            RefreshDisplay();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _fileName = saveFileDialog1.FileName;
            File.WriteAllText(_fileName, _user.Cube.ToString());
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _fileName = openFileDialog1.FileName;

            try
            {
                LoadCube();
                timer1.Start();
            }
            catch (IOException)
            {
                MessageBox.Show(@"This is not a valid Skibur file.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _user.Cube.ElapsedTime++;
            lblElapsedTime.Text = string.Format("Elapsed Time: {0}", NiceTime(_user.Cube.ElapsedTime));
        }

        private void tblLeft_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            CubiePaint(Cube.Left, e);
        }

        private void tblRight_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            CubiePaint(Cube.Right, e);
        }

        private void tblUp_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            CubiePaint(Cube.Up, e);
        }

        private void tblDown_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            CubiePaint(Cube.Down, e);
        }

        private void tblFront_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            CubiePaint(Cube.Front, e);
        }

        private void tblBack_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            CubiePaint(Cube.Back, e);
        }

        #endregion

        #region -- Turn Methods --

        private void btnL1Turn_Click(object sender, EventArgs e)
        {
            _user.Turn(Cube.Left, Cube.Clockwise);
            RefreshDisplay();
            if (_user.Cube.IsSolved())
                CubeIsSolved();
        }

        private void btnL2Turn_Click(object sender, EventArgs e)
        {
            _user.Turn(Cube.Left, Cube.Double);
            RefreshDisplay();
            if (_user.Cube.IsSolved())
                CubeIsSolved();
        }

        private void btnL3Turn_Click(object sender, EventArgs e)
        {
            _user.Turn(Cube.Left, Cube.CounterClockwise);
            RefreshDisplay();
            if (_user.Cube.IsSolved())
                CubeIsSolved();
        }

        private void btnR1Turn_Click(object sender, EventArgs e)
        {
            _user.Turn(Cube.Right, Cube.Clockwise);
            RefreshDisplay();
            if (_user.Cube.IsSolved())
                CubeIsSolved();
        }

        private void btnR2Turn_Click(object sender, EventArgs e)
        {
            _user.Turn(Cube.Right, Cube.Double);
            RefreshDisplay();
            if (_user.Cube.IsSolved())
                CubeIsSolved();
        }

        private void btnR3Turn_Click(object sender, EventArgs e)
        {
            _user.Turn(Cube.Right, Cube.CounterClockwise);
            RefreshDisplay();
            if (_user.Cube.IsSolved())
                CubeIsSolved();
        }

        private void btnU1Turn_Click(object sender, EventArgs e)
        {
            _user.Turn(Cube.Up, Cube.Clockwise);
            RefreshDisplay();
            if (_user.Cube.IsSolved())
                CubeIsSolved();
        }

        private void btnU2Turn_Click(object sender, EventArgs e)
        {
            _user.Turn(Cube.Up, Cube.Double);
            RefreshDisplay();
            if (_user.Cube.IsSolved())
                CubeIsSolved();
        }

        private void btnU3Turn_Click(object sender, EventArgs e)
        {
            _user.Turn(Cube.Up, Cube.CounterClockwise);
            RefreshDisplay();
            if (_user.Cube.IsSolved())
                CubeIsSolved();
        }

        private void btnD1Turn_Click(object sender, EventArgs e)
        {
            _user.Turn(Cube.Down, Cube.Clockwise);
            RefreshDisplay();
            if (_user.Cube.IsSolved())
                CubeIsSolved();
        }

        private void btnD2Turn_Click(object sender, EventArgs e)
        {
            _user.Turn(Cube.Down, Cube.Double);
            RefreshDisplay();
            if (_user.Cube.IsSolved())
                CubeIsSolved();
        }

        private void btnD3Turn_Click(object sender, EventArgs e)
        {
            _user.Turn(Cube.Down, Cube.CounterClockwise);
            RefreshDisplay();
            if (_user.Cube.IsSolved())
                CubeIsSolved();
        }

        private void btnF1Turn_Click(object sender, EventArgs e)
        {
            _user.Turn(Cube.Front, Cube.Clockwise);
            RefreshDisplay();
            if (_user.Cube.IsSolved())
                CubeIsSolved();
        }

        private void btnF2Turn_Click(object sender, EventArgs e)
        {
            _user.Turn(Cube.Front, Cube.Double);
            RefreshDisplay();
            if (_user.Cube.IsSolved())
                CubeIsSolved();
        }

        private void btnF3Turn_Click(object sender, EventArgs e)
        {
            _user.Turn(Cube.Front, Cube.CounterClockwise);
            RefreshDisplay();
            if (_user.Cube.IsSolved())
                CubeIsSolved();
        }

        private void btnB1Turn_Click(object sender, EventArgs e)
        {
            _user.Turn(Cube.Back, Cube.Clockwise);
            RefreshDisplay();
            if (_user.Cube.IsSolved())
                CubeIsSolved();
        }

        private void btnB2Turn_Click(object sender, EventArgs e)
        {
            _user.Turn(Cube.Back, Cube.Double);
            RefreshDisplay();
            if (_user.Cube.IsSolved())
                CubeIsSolved();
        }

        private void btnB3Turn_Click(object sender, EventArgs e)
        {
            _user.Turn(Cube.Back, Cube.CounterClockwise);
            RefreshDisplay();
            if (_user.Cube.IsSolved())
                CubeIsSolved();
        }

        #endregion

        #region -- Rotation Methods --

        private void btnX1Rotate_Click(object sender, EventArgs e)
        {
            _user.Rotate(Axis.X, Cube.Clockwise);
            RefreshDisplay();
        }

        private void btnX2Rotate_Click(object sender, EventArgs e)
        {
            _user.Rotate(Axis.X, Cube.Double);
            RefreshDisplay();
        }

        private void btnX3Rotate_Click(object sender, EventArgs e)
        {
            _user.Rotate(Axis.X, Cube.CounterClockwise);
            RefreshDisplay();
        }

        private void btnY1Rotate_Click(object sender, EventArgs e)
        {
            _user.Rotate(Axis.Y, Cube.Clockwise);
            RefreshDisplay();
        }

        private void btnY2Rotate_Click(object sender, EventArgs e)
        {
            _user.Rotate(Axis.Y, Cube.Double);
            RefreshDisplay();
        }

        private void btnY3Rotate_Click(object sender, EventArgs e)
        {
            _user.Rotate(Axis.Y, Cube.CounterClockwise);
            RefreshDisplay();
        }

        private void btnZ1Rotate_Click(object sender, EventArgs e)
        {
            _user.Rotate(Axis.Z, Cube.Clockwise);
            RefreshDisplay();
        }

        private void btnZ2Rotate_Click(object sender, EventArgs e)
        {
            _user.Rotate(Axis.Z, Cube.Double);
            RefreshDisplay();
        }

        private void btnZ3Rotate_Click(object sender, EventArgs e)
        {
            _user.Rotate(Axis.Z, Cube.CounterClockwise);
            RefreshDisplay();
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;

namespace Games
{
    public partial class Survival_IngegneGames : Form
    {
        private Character player;

        public Survival_IngegneGames()
        {
            InitializeComponent();
            player = new Character("Pippo", 5);
        }
    }
}

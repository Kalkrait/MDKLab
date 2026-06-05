using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Linq;



    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new EmployeeForm());
    }
}
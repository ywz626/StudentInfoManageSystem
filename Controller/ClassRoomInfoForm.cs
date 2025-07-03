using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentInfoManageSystem.Service;
using StudentInfoManageSystem.Service.Impl;

namespace StudentInfoManageSystem.Controller
{
    public partial class ClassRoomInfoForm : UIForm
    {
        public ClassRoomService classRoomService = new ClassRoomServiceImpl ();
        public ClassRoomInfoForm()
        {
            InitializeComponent();
        }

        private void ClassRoomInfoForm_Load(object sender, EventArgs e)
        {
            List<string> buildings = classRoomService.getAllBuildings();
            foreach (string build in buildings)
            {
                building.Items.Add(build);
            }

        }

        private void query_Click(object sender, EventArgs e)
        {
            string buildingName = building.Text.Trim();
            string roomName = room.Text.Trim();
            DataTable dataTable = classRoomService.getRooms(buildingName, roomName);
            data.DataSource = dataTable;
            data.Columns["name"].HeaderText = "教学楼";
            data.Columns["status"].HeaderText = "状态";
            data.Columns["buildingName"].HeaderText = "教学楼";
        }
    }
}

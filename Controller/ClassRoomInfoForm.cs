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
using StudentInfoManageSystem.Models.DTO;

namespace StudentInfoManageSystem.Controller
{
    public partial class ClassRoomInfoForm : UIForm
    {
        public ClassRoomService classRoomService = new ClassRoomServiceImpl ();
        public ClassRoomInfoForm()
        {
            InitializeComponent();
        }

        public ClassRoomInfoForm(RoomQueryDTO queryDTO)
        {
            InitializeComponent();
            building.Text = queryDTO.buildingName;
            room.Text = queryDTO.roomName;
            roomStatus.Text = queryDTO.status;
            query_Click(null, null);
        }

        private void ClassRoomInfoForm_Load(object sender, EventArgs e)
        {
            List<string> buildings = classRoomService.getAllBuildings();
            foreach (string build in buildings)
            {
                building.Items.Add(build);
            }
            roomStatus.Items.Add("维修中");
            roomStatus.Items.Add("被占用");
            roomStatus.Items.Add("空闲");
        }

        private void query_Click(object sender, EventArgs e)
        {
            string buildingName = building.Text.Trim();
            string roomName = room.Text.Trim();
            string status = roomStatus.Text.Trim();
            int? statusId = null;
            if (status == "维修中")
            {
                statusId = 0;
            }
            else if (status == "被占用")
            {
                statusId = 1;
            }
            else if(status == "空闲")
            {
                statusId = 2;
            }
            RoomQueryDTO queryDTO = new RoomQueryDTO
            {
                buildingName = buildingName,
                roomName = roomName,
                statusId = statusId
            };
            DataTable dataTable = classRoomService.getRooms(queryDTO);
            data.DataSource = dataTable;
            data.Columns["name"].HeaderText = "教学楼";
            data.Columns["status"].HeaderText = "状态";
            data.Columns["buildingName"].HeaderText = "教学楼";
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string buildingName = building.Text.Trim();
            string roomName = room.Text.Trim();
            RoomQueryDTO queryDTO = new RoomQueryDTO
            {
                buildingName = buildingName,
                roomName = roomName,
            };
            bool check = classRoomService.update(queryDTO);
            if (check)
            {
                MessageBox.Show("借用成功！");
            }
            else
            {
                MessageBox.Show("借用失败");
            }
        }
    }
}

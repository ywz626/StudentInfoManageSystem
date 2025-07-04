using StudentInfoManageSystem.Models.DTO;
using StudentInfoManageSystem.Service;
using StudentInfoManageSystem.Service.Impl;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentInfoManageSystem.Controller
{
    public partial class AdminRoomForm : UIForm
    {
        public ClassRoomService classRoomService = new ClassRoomServiceImpl();

        public AdminRoomForm()
        {
            InitializeComponent();
        }

        private void query_Click(object sender, EventArgs e)
        {
            string buildingName = building.Text.Trim();
            string roomName = room.Text.Trim();
            string status = roomStatus.Text.Trim();
            int? statusId = null;
            if(status == "维修中")
            {
                statusId = 0;
            }
            else if(status == "被占用")
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
                statusId = statusId,
                status = status
            }; 
            ClassRoomInfoForm classRoomInfoForm = new ClassRoomInfoForm(queryDTO);
            classRoomInfoForm.Show();
        }

        private void AdminRoomForm_Load(object sender, EventArgs e)
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

        private void update_Click(object sender, EventArgs e)
        {
            string buildingName = building.Text.Trim();
            string roomName = room.Text.Trim();
            string status = roomStatus.Text.Trim();
            if (string.IsNullOrEmpty(buildingName) || string.IsNullOrEmpty(roomName) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("请填写完整信息");
                return;
            }
            int? statusId = null;
            if (status == "维修中")
            {
                statusId = 0;
            }
            else if (status == "被占用")
            {
                statusId = 1;
            }
            else
            {
                statusId = 2;
            }
            RoomQueryDTO queryDTO = new RoomQueryDTO
            {
                buildingName = buildingName,
                roomName = roomName,
                statusId = statusId,
                status = status
            };
            bool check = classRoomService.update(queryDTO);
            if (check)
            {
                MessageBox.Show("修改成功！");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }
    }
}

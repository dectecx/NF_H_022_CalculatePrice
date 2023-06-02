using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatePrice.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 首頁
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 計算房價
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="roomType"></param>
        /// <param name="numDays"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult CalculatePrice(string userName, string roomType, int numDays)
        {
            // 姓名
            ViewBag.UserName = userName;
            // 訂房天數
            ViewBag.NumDays = numDays;

            // 房型名稱
            string roomName = "";
            // 房型轉換價格
            int roomPrice = 0;
            switch (roomType)
            {
                // 山景
                case "mountainView":
                    roomName = "山景 - NT$2,500";
                    roomPrice = 2500; 
                    break;
                // 河景
                case "riverView":
                    roomName = "河景 - NT$3,000";
                    roomPrice = 3000;
                    break;
                // 走道
                case "aislePlace":
                    roomName = "走道 - NT$2,000";
                    roomPrice = 2000;
                    break;
                default: roomPrice = 0; break;
            };
            // 房型名稱
            ViewBag.RoomName = roomName;
            // 總費用
            ViewBag.TotalPrice = roomPrice * numDays;
            return View();
        }
    }
}
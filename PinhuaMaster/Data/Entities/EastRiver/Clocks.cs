using System;
using System.Collections.Generic;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class Clocks
    {
        public int ClockId { get; set; }
        public string ClockName { get; set; }
        public string ClockType { get; set; }
        public string AreaId { get; set; }
        public string DinRoomId { get; set; }
        public bool IsCount { get; set; }
        public int? ComPort { get; set; }
        public int? BaudRate { get; set; }
        public string OutInType { get; set; }
        public int? DoorType { get; set; }
        public string UseType { get; set; }
        public string ClockModel { get; set; }
        public string StateTime { get; set; }
        public string PassSegTime { get; set; }
        public string PointState { get; set; }
        public string SetHolidDay { get; set; }
        public string HolidSegTime { get; set; }
        public string SupUser { get; set; }
        public string SupSegTime { get; set; }
        public bool OverControl { get; set; }
        public string Wrparam { get; set; }
        public string GroupParam { get; set; }
        public string MealParam { get; set; }
        public bool? Isic { get; set; }
        public string VerNo { get; set; }
        public string Remark { get; set; }
        public string TcpipAddress { get; set; }
        public int? TcpipPort { get; set; }
        public int? TcpipType { get; set; }
        public int? TcpipModel { get; set; }
        public string TcpipPassWord { get; set; }
        public int? ParityKind { get; set; }
        public int? Vender { get; set; }
        public int CardFormat { get; set; }
        public string MachineId { get; set; }
        public byte? Consumetype { get; set; }
        public string Listfmt { get; set; }
        public int BlackcardId { get; set; }
        public int? LastPicIndex { get; set; }
        public int WhitecardId { get; set; }
        public int? PasscardId { get; set; }
        public int AllowanceId { get; set; }
        public string Settingxml { get; set; }
        public bool? Done { get; set; }
        public string Groups { get; set; }
        public string SerialNo { get; set; }
        public int? NLogicalId { get; set; }
    }
}

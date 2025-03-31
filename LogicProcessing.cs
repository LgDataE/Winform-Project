using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Policy;

namespace WindowsFormsApp1
{
    public class LogicProcessing
    {
        private DataAccess dataAccess;
        public LogicProcessing()
        {
            dataAccess = new DataAccess();
        }

        public DataTable GetUserData()
        {
            return dataAccess.GetUserData();
        }

        public DataTable SearchUserByPhone(string phone)
        {
            return dataAccess.SearchUserByPhone(phone);
        }

        public DataTable SearchUserByUsername(string username)
        {
            return dataAccess.SearchUserByUsername(username);
        }

        public void AddMoneyToUser(int userID, long amount)
        {
            dataAccess.AddMoneyToUser(userID, amount);
        }

        public void DeleteUser(int userID)
        {
            dataAccess.DeleteUser(userID);
        }

        public bool UpdateUserData(int userID, string columnName, string updatedValue)
        {
            return dataAccess.UpdateUserData(userID, columnName, updatedValue);
        }


        public bool CheckIfPhoneExists(string phone)
        {
            return dataAccess.CheckIfPhoneExists(phone);
        }

        public bool CheckIfUsernameExists(string username)
        {
            return dataAccess.CheckIfUsernameExists(username);
        }

        public void AddNewUser(UserDTO user)
        {
            dataAccess.AddNewUser(user);
        }

        public long CalculateAmountToDeduct(DateTime registrationTime)
        {
            TimeSpan timeDifference = DateTime.Now - registrationTime;
            long minutesElapsed = (long)timeDifference.TotalMinutes;
            return minutesElapsed * 100; // Giả sử 1 phút = 100 đơn vị
        }

        public void PerformPayment(int userID, long amountToDeduct)
        {
            dataAccess.DeductMoneyFromUser(userID, amountToDeduct);
            UpdateUserStatusToOffline(userID);
        }

        public void UpdateUserStatusToOffline(int userID)
        {
            dataAccess.UpdateUserStatus(userID, "Offline");
        }

    }
}

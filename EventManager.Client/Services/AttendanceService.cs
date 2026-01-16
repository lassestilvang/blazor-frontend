
using System;
using System.Collections.Generic;

namespace EventManager.Client.Services
{
    public class AttendanceService
    {
        public event Action? OnChange;
        
        private HashSet<string> _checkedInUsers = new HashSet<string>();

        public void CheckIn(string user)
        {
            if (_checkedInUsers.Add(user))
            {
                NotifyStateChanged();
            }
        }

        public void CheckOut(string user)
        {
            if (_checkedInUsers.Remove(user))
            {
                NotifyStateChanged();
            }
        }

        public bool IsCheckedIn(string user)
        {
            return _checkedInUsers.Contains(user);
        }
        
        public int GetCount() => _checkedInUsers.Count;
        
        public IEnumerable<string> GetCheckedInUsers() => _checkedInUsers;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_ANDROID
using Unity.Notifications.Android;
#elif Unity_IOS
using using Unity.Notifications.IOS;
#endif

public class MonetizationManager : MonoBehaviour
{
    
    void Start()
    {
#if UNITY_ANDROID
        var channel = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Default Channel",
            Importance = Importance.Default,            
            Description = "Generic notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(channel);
#endif
    }

    
    void Update()
    {
        
    }


    public void SendLocalNotification(string title, string msg)
    {
#if UNITY_ANDROID
        var notification = new AndroidNotification();
        notification.Title = title;
        notification.Text = msg;
        notification.LargeIcon = "large_icon";
        notification.FireTime = System.DateTime.Now.AddHours(24);

        AndroidNotificationCenter.SendNotification(notification, "channel_id");
    }
#elif UNITY_IOS
#endif
    
}


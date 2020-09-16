using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockController : MonoBehaviour
{
    class Timer
    {


    
        public static float Seconds
        {
            get;
            private set;
        }
        public static int setSeconds(float newSeconds)
        {
            Seconds = newSeconds;
            int extraMinutes = (int)(Seconds / 60f);

            Seconds -= extraMinutes * 60;
            return setMinutes(Minutes + extraMinutes);
        }
        public static int Minutes
        {
            get;
            private set;
        }
        public static int setMinutes(int newMinutes)
        {
            Minutes = newMinutes;
            int changedDays = setHours(Hours+Minutes / 60);
            Minutes = Minutes % 60;

            return changedDays;
        }

        public static int Hours
        {
            get;
            private set;
        }

        public static int setHours(int newHour)
        {
            int changedDays = 0;

            Hours = newHour;
            changedDays = Hours/24;

            Hours = Hours % 24;

            return changedDays;
        }
    }



    public Text MonthVisuals;
    public Text DayVisuals;

    public Image HourFirstDigit;
    public Image HourSecondDigit;

    public Image MinuteFirstDigit;
    public Image MinuteSecondDigit;

    public Sprite[] digits = new Sprite[10];


    public enum Months {JAN,FEB,MAR,APR,MAY,JUN,JUL,AUG,SEP,OCT,NOV,DEC }
    public enum Days { MON,TUE,WED,THU,FRI,SAT,SUN}

    private Months month;
    public Months Month
    {
        get { return month; } 
        private set 
        {
            month = value;
            UpdateMonthDayVisuals();
        }
    }
    private Days day;
    public Days Day
    {
        get { return day; }
        private set 
        {
            day = value;
            UpdateMonthDayVisuals();
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        Month = Months.JUL;
        Day = Days.MON;

        Timer.setHours(23);
        Timer.setMinutes(59);
        Timer.setSeconds(50);
        UpdateTimeVisuals();
    }

    // Update is called once per frame
    void Update()
    {
        int oldMinutes = Timer.Minutes;
        
        if (Timer.setSeconds(Timer.Seconds + Time.deltaTime) > 0)
        {
            switch (Day)
            {
                case Days.MON:
                    Day = Days.TUE;
                    break;
                case Days.TUE:
                    Day = Days.WED;
                    break;
                case Days.WED:
                    Day = Days.THU;
                    break;
                case Days.THU:
                    Day = Days.FRI;
                    break;
                case Days.FRI:
                    Day = Days.SAT;
                    break;
                case Days.SAT:
                    Day = Days.SUN;
                    break;
                case Days.SUN:
                    Day = Days.MON;
                    break;
            }
        }

        if (Timer.Minutes != oldMinutes)
        {
            UpdateTimeVisuals();
        }
        
    }


    private void UpdateMonthDayVisuals()
    {
        MonthVisuals.text = month.ToString();
        DayVisuals.text = day.ToString();
    }
    private void UpdateTimeVisuals()
    {
        HourFirstDigit.sprite = digits[Timer.Hours / 10];
        HourSecondDigit.sprite = digits[Timer.Hours % 10];
        MinuteFirstDigit.sprite = digits[Timer.Minutes / 10];
        MinuteSecondDigit.sprite = digits[Timer.Minutes % 10];
    }
}

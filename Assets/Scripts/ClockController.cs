using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockController : MonoBehaviour
{
    class Timer
    {
        private static float seconds;
        public static float Seconds
        {
            get { return seconds; }
        }
        public static int setSeconds(float newSeconds)
        {
            seconds = newSeconds;
            int extraMinutes = (int)(seconds / 60f);
            seconds = seconds - extraMinutes * 60;
            return setMinutes(Minutes + extraMinutes);
        }
        private static int minutes;
        public static int Minutes
        {
            get { return minutes; }
        }
        public static int setMinutes(int newMinutes)
        {
            minutes = newMinutes;
            int changedDays = setHours(Hours+minutes / 60);
            minutes = minutes % 60;

            return changedDays;
        }

        private static int hours;
        public static int Hours
        {
            get { return hours; }
        }

        public static int setHours(int newHour)
        {
            int changedDays = 0;

            hours = newHour;
            changedDays = hours/24;

            hours = hours % 24;

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

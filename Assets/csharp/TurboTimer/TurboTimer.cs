using System;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class TurboTimer : MonoBehaviour
{
    #region Unity Engine Exposed Fields
    /// <summary>
    /// Time is given in miliseconds. Only affects the first time
    /// the timer is started.
    /// </summary>
    [SerializeField] private bool autoStart;
    [SerializeField] private int startTime;
    [SerializeField] private GameObject minutesDisplay;
    [SerializeField] private GameObject secondsDisplay;
    [SerializeField] private GameObject centiSecondsDisplay;
    #endregion

    #region Unity Engine Exposed Field Derived
    private TimeSpan _initialStartTime;
    private bool _initialTimerStart;
    private TextMeshProUGUI _minutesComponent;
    private TextMeshProUGUI _secondsComponent;
    private TextMeshProUGUI _centiSecondsComponent;
    #endregion

    #region Fields
    private DateTime _timerStart;
    private TimeSpan _staticTime;
    private bool _isStopped;
    private List<TimeSpan> _timestamps;
    #endregion

    #region Properties
    public bool IsRunning => !_isStopped;
    public bool IsStopped => _isStopped;
    public TimeSpan CurrentTime => IsRunning ? (DateTime.Now - _timerStart) + _staticTime : _staticTime;
    public List<TimeSpan> Timestamps => _timestamps;
    #endregion

    #region Control Methods
    /// <summary>
    /// Starts the timer.
    /// </summary>
    public TurboTimer StartTimer()
    {
        _isStopped = false;
        _timerStart = DateTime.Now;

        if (_initialTimerStart)
        {
            _staticTime += _initialStartTime;
        }
        
        return this;
    }

    /// <summary>
    /// Stops the timer, preserving the CurrentTime.
    /// </summary>
    public TurboTimer StopTimer()
    {
        _isStopped  = true;
        _staticTime = CurrentTime;
        return this;
    }

    /// <summary>
    /// Resets the timer to zero, but does not stop it from running and
    /// does not clear any saved timestamps.
    /// </summary>
    public TurboTimer ResetTimer()
    {
        _staticTime = new TimeSpan();
        _timerStart = DateTime.Now;
        return this;
    }

    /// <summary>
    /// Completely resets the timer, stopping it and clearing all timestamps.
    /// </summary>
    public TurboTimer FullResetTimer() =>
        StopTimer()
        .ClearTimestamps()
        .ResetTimer();

    /// <summary>
    /// Completely resets the timer, clears all timestamps and then starts it again.
    /// </summary>
    public TurboTimer RestartTimer() =>
        FullResetTimer()
        .StartTimer();

    /// <summary>
    /// Creates a new Timestamp.
    /// </summary>
    public TurboTimer NewTimestamp()
    {
        _timestamps.Add(CurrentTime);
        return this;
    }

    /// <summary>
    /// Empties the list of saved timestamps.
    /// </summary>
    public TurboTimer ClearTimestamps()
    {
        _timestamps.Clear();
        return this;
    }

    /// <summary>
    /// Adds a TimeSpan to the TurboTimer.
    /// </summary>
    public TurboTimer AddTimeSpan(TimeSpan timeSpan)
    {
        _staticTime += timeSpan;
        return this;
    }
    #endregion

    #region MonoBehavior Methods
    /// <summary>
    /// Start is called once before the first execution of Update after the MonoBehaviour is created
    /// </summary>
    void Start()
    {
        _initialStartTime = new TimeSpan(0, 0, 0, 0, startTime);
        _initialTimerStart = true;
        _timestamps = new List<TimeSpan>();

        _minutesComponent      = minutesDisplay.GetComponent<TextMeshProUGUI>();
        _secondsComponent      = secondsDisplay.GetComponent<TextMeshProUGUI>();
        _centiSecondsComponent = centiSecondsDisplay.GetComponent<TextMeshProUGUI>();

        FullResetTimer();

        if (autoStart)
        {
            StartTimer();
        }
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        TimeSpan t = CurrentTime;
        _minutesComponent.text      = t.Minutes.ToString();
        _secondsComponent.text      = $":{t.Seconds:D2}";
        _centiSecondsComponent.text = $":{t.Milliseconds/10:D2}";
    }

    /// <summary>
    /// Update is called at a fixed frame-rate
    /// </summary>
    void FixedUpdate()
    {
        //
    }
    #endregion
}

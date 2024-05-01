# SimpleLog

Simple drop in open source library for quick console logging.

![alt text](https://github.com/itsEvil/SimpleLog/blob/master/Capture.PNG?raw=true)

### How to setup

1. Simply add SLog.cs into your project.
2. Convert your existing logging method to use this. 
3. Done!

For applications using Application.CreateBuilder();
add this line before ```builder.Build();```
This removes microsoft logging
```builder.Logging.ClearProviders();```

### Notes 


You no longer have to call SLog.Terminate() when closing your application to stop the loggers worker
thread as I marked it as a background thread and automatically should close when closing the application.

But you can if you want to stop the logger from working.

Easy and simple configuration.

To modify logger look in 
- SLogConfig class for configuration
- SLogColors class for console colors 
- SLog.Format() method to change the format used

Termination also happens when Fatal(string message, [bool terminate = true]) is called with terminate set to true.

### How does it work?

When the user calls any of the public methods 'Debug' 'Trace' etc,
it formats the message and adds it to the queue to be processed.

On startup, it creates a new worker thread which runs until termination. 
Each tick of this thread it tries to dequeue all 'ConsoleMessages' from '_messages' queue.
After its done with the queue it sleeps for 'SLogConfig.SleepTime' MS.



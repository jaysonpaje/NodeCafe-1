'THIS CODE WAS NOT IMPLEMENTED BY ME

'Many thanks for Rakesh Mehta for the great code in multithreading
'http://www.codeproject.com/Articles/15104/Multithreading-with-VB-NET-A-beginner-s-choice
'CHEERS
Imports System.Threading

Public Class clsThread
    'This variable will hold the Thread Index that are passed from the main window, when we created it
    Private m_ThreadIndex As Integer
    'This is local thread variable. We will send the value of this variable to the parent form
    Private m_Counter As Integer = 0
    'We will need this variable to pass argument to the method of the main window
    Private m_Args(1) As Object
    'This will hold the ref to the main window,
    Private m_MainWindow As Form
    'We have to create a delegate to call the Notification Method on the main form (ReceiveThreadMessage())
    'Delegate is nothing, but a Type Safe Pointer. It works same way like Callback function in C++/VC++
    'If you like to know more about delegates plz visit http://www.15seconds.com/issue/020815.htm
    'This delegate sub should have same signature (declaration) as the method, that are there in the main from.
    'Which we will call from this thread. 

    'Here we are going to call the method ReceiveThreadMessage() of the main form. 
    'So the declaration of the delegate should be same as ReceiveThreadMessage()

    Private Delegate Sub NotifyMainWindow(ByVal ThreadIndex As Integer, ByVal Counter As Integer)
    Private Delegate Sub Update()
    'We need an object of this delegate
    Private m_NotifyMainWindow As NotifyMainWindow
    Private m_NotifyMainWindow2 As Update

    Public Sub New(ByVal ThreadIndex As Integer, ByRef MainWindow As frmBG)
        m_ThreadIndex = ThreadIndex
        m_MainWindow = MainWindow

        'We need to point our delegate to the Method, which we want to call from this thread
        m_NotifyMainWindow = AddressOf MainWindow.ReceiveThreadMessage
        ' m_NotifyMainWindow2 = AddressOf MainWindow.updateT
    End Sub
    Public Sub Callback(ByVal ar As IAsyncResult)
        ar.AsyncState.EndInvoke(ar)
    End Sub
    Public Sub StartThread()
        While True
            m_Counter = m_Counter + 1

            ReDim m_Args(1)
            m_Args(0) = m_ThreadIndex
            m_Args(1) = m_Counter

            'Call the notificaiton method on the main window by the delegate
            If m_MainWindow.InvokeRequired Then
                m_MainWindow.Invoke(m_NotifyMainWindow, m_Args)
            Else
                'Dim RunDelegate As AsyncDelegate = AddressOf Run
                'RunDelegate.BeginInvoke(AddressOf Callback, RunDelegate)
                'm_MainWindow.Dispose()
                'm_NotifyMainWindow2.BeginInvoke(AddressOf Callback,m_NotifyMainWindow2)
                m_NotifyMainWindow.BeginInvoke(m_ThreadIndex, m_Counter, AddressOf Callback, m_NotifyMainWindow)

            End If
            'wait for some time before continuing loop
            Thread.Sleep(100)
            'Thread.Sleep(1014.4)
        End While
    End Sub
End Class

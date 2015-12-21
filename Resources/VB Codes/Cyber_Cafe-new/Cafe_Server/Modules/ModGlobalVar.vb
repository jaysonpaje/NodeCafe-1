Module ModGlobalVar

    Public btn(40) As Button
    Public pnl(40) As Panel
    Public lblIn(40) As Label
    Public lblOut(40) As Label
    Public lblInT(40) As Label
    Public lblOutT(40) As Label
    Public lblelpsed(40) As Label
    Public lblPay(40) As Label
    Public lblPayment(40) As Label
    Public elpsedT(40) As Label 'timer elapse
    Public lblUnpaid(40) As Label
    Public lblUnpaidT(40) As Label
    Public grp(40) As GroupBox
    Public chcbx(40) As CheckBox
    Public _secs(40) As Long
    Public _mins(40) As Long
    Public _tmpsecs(40) As Integer
    Public _tmpsecsNow(40) As Integer
    Public _hrs(40) As Integer
    Public _elapseTime(40) As String
    Public _notify(40) As Boolean
    Public AmtinMin(40) As Integer
    Public AmtinHr As Integer
    Public AmtinHrs(40) As Integer
    Public IsMin(40) As Integer
    Public IsDisc As Integer
    Public _tmpSetTime_(40) As Integer 'time settings to be..
    Public _checkRun(40) As Boolean 'check if the client timer is first use. purpose: server restart while client is open

    Public m_ThreadList As New ArrayList

    Public _packet_msg As String
    Public global_timer As Integer = 0
    Public _start(40) As Long
    Public DiscON(40) As Integer
    Public _btnClick(40) As Long
    Public _prevIndex As Long = 0

    Public testElpase As TimeSpan
    Public timeEn, timeSt As DateTime
    Public h, m, sec As Integer
    Public OpenTimeStart, timestart, timeend As New DateTime
    Public UsedTime As New TimeSpan
    Public chktimeHR, chktimeMIN, amountTopay, amountTopayMin As Integer
    ' amountTopayHR As Integer
    Public fmins As Integer

    'toggle to get if paid or not
    Public _bolPaid(40) As Boolean

    Public _mRates(0) As Integer 'global rates, so that you can query it easily without using sql statement
    Public mReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Public Rpt_SqlStr As String ' for report query
End Module

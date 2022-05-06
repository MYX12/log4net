Module Module1
    Private logger As log4net.ILog = log4net.LogManager.GetLogger(GetType(Module1).ToString)

    Sub Main()
        Try
            logger.Info("this is start of do work")
            Dowork()
            logger.Info("this is the end of do work")
        Catch ex As Exception
            logger.Error("your app has an error")
            logger.Error(ex.Message)
        End Try

    End Sub
    Private Sub Dowork()
        Console.WriteLine("this is the do work function")

    End Sub
End Module

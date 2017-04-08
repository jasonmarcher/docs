' The following code example demonstrates the effect of changing the NumberDecimalSeparator property.

' <snippet1>
Imports System
Imports System.Globalization

Class NumberFormatInfoSample

   Public Shared Sub Main()

      ' Gets a NumberFormatInfo associated with the en-US culture.
      Dim nfi As NumberFormatInfo = New CultureInfo("en-US", False).NumberFormat

      ' Displays a value with the default separator (".").
      Dim myInt As Int64 = 123456789
      Console.WriteLine(myInt.ToString("N", nfi))

      ' Displays the same value with a blank as the separator.
      nfi.NumberDecimalSeparator = " "
      Console.WriteLine(myInt.ToString("N", nfi))

   End Sub 'Main 

End Class 'NumberFormatInfoSample







' </snippet1>
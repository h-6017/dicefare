Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace dCC_lab_10_3
	Friend Class Program
		Private Shared odd_word As String

		Private Shared middle As Integer

		Private Shared first_part As String

		Private Shared second_part As String

		Shared Sub New()
			Program.middle = 0
		End Sub

		Public Sub New()
			MyBase.New()
		End Sub

        Public Shared Sub Main(ByVal args As String())
            Console.WriteLine("Number of command line parameters = {0}", CInt(args.Length))
            If (args.Count() Mod 2 <> 0) Then
                Dim odd_word As String = args(CInt(args.Length) / 2)
                Program.middle = odd_word.Length / 2
                Program.first_part = odd_word.Substring(0, Program.middle)
                Program.second_part = odd_word.Substring(Program.middle)
            End If
            Dim total_args As Integer = CInt(args.Length)
            Dim second_half As Integer = total_args - total_args / 2
            Dim arguments_first_half As List(Of String) = New List(Of String)()
            Dim arguments_second_half As List(Of String) = New List(Of String)()
            Dim i As Integer = 0
            While i < total_args / 2
                arguments_first_half.Add(args(i))
                i = i + 1
            End While
            arguments_first_half.Add(Program.first_part)
            arguments_second_half.Add(Program.second_part)
            i = second_half
            While i < total_args
                arguments_second_half.Add(args(i))
                i = i + 1
            End While
            i = 0
            While i < arguments_first_half.Count
                Console.Write(String.Concat(arguments_first_half(i), " "))
                i = i + 1
            End While
            Console.WriteLine()
            i = 0
            While i < arguments_second_half.Count
                Console.Write(String.Concat(arguments_second_half(i), " "))
                i = i + 1
            End While
            Console.ReadKey()
        End Sub
	End Class
End Namespace
Imports System.Data.Common
Imports System.Net
Imports SnmpSharpNet
Public Class Form1
    Dim dt As New DataTable


    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        ComboBox1.Items.Add("Ver. 1")
        ComboBox1.Items.Add("Ver. 2")
        ComboBox1.SelectedIndex = 0

        DataGridView1.DataSource = dt
        DataGridView1.RowHeadersVisible = False
        DataGridView1.ReadOnly = True
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Me.FormBorderStyle = FormBorderStyle.FixedSingle

        Me.MaximizeBox = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resultados As New List(Of String)
        dt.Rows.Clear()
        Dim versao As String = versão(ComboBox1.Text)
        Dim Endereço As String = txt_endereço.Text
        Dim comunidade As String = txt_comunidade.Text
        Dim snmp As SimpleSnmp = New SimpleSnmp(Endereço, comunidade)
        Dim result As Dictionary(Of Oid, AsnType) = snmp.Walk(versao, TextBox2.Text)

        If result Is Nothing Then
            MsgBox("Erro")
        Else

            For Each entry As KeyValuePair(Of Oid, AsnType) In result
                dt.Rows.Add(entry.Key.ToString(), entry.Value)
            Next
            MsgBox("Pronto")
        End If



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim filtro As String = txt_pesquisa.Text
        Dim dv As New DataView(dt)
        dv.RowFilter = $"Convert(VALUE, 'System.String') = '{filtro}'"

        DataGridView1.DataSource = dv.ToTable()
    End Sub

    Public Function versão(_versao As String)
        If _versao = "Ver. 1" Then
            Return SnmpVersion.Ver1
        ElseIf _versao = "Ver. 2" Then
            Return SnmpVersion.Ver2
        End If
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt.Columns.Add("OID", GetType(String))
        dt.Columns.Add("VALUE", GetType(String))
        DataGridView1.Columns("OID").Width = 416
        DataGridView1.Columns("VALUE").Width = 416
    End Sub

End Class

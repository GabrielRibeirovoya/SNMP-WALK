<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        GroupBox1 = New GroupBox()
        Label5 = New Label()
        Label4 = New Label()
        Button3 = New Button()
        Label3 = New Label()
        txt_pesquisa = New TextBox()
        Button2 = New Button()
        Button1 = New Button()
        txt_comunidade = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        ComboBox1 = New ComboBox()
        txt_endereço = New TextBox()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txt_pesquisa)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(txt_comunidade)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(txt_endereço)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 6)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(833, 140)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(663, 23)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 20)
        Label5.TabIndex = 11
        Label5.Text = "Pesquisar"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(422, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 20)
        Label4.TabIndex = 10
        Label4.Text = "OID Root"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(663, 99)
        Button3.Name = "Button3"
        Button3.Size = New Size(158, 27)
        Button3.TabIndex = 8
        Button3.Text = "Filtrar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(315, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 9
        Label3.Text = "Versão SNMP"
        ' 
        ' txt_pesquisa
        ' 
        txt_pesquisa.Location = New Point(663, 46)
        txt_pesquisa.Name = "txt_pesquisa"
        txt_pesquisa.Size = New Size(158, 27)
        txt_pesquisa.TabIndex = 7
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(499, 99)
        Button2.Name = "Button2"
        Button2.Size = New Size(158, 27)
        Button2.TabIndex = 6
        Button2.Text = "Stop"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(315, 99)
        Button1.Name = "Button1"
        Button1.Size = New Size(178, 27)
        Button1.TabIndex = 5
        Button1.Text = "Walk"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txt_comunidade
        ' 
        txt_comunidade.Location = New Point(6, 99)
        txt_comunidade.Name = "txt_comunidade"
        txt_comunidade.Size = New Size(303, 27)
        txt_comunidade.TabIndex = 4
        txt_comunidade.Text = "public"
        txt_comunidade.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 20)
        Label2.TabIndex = 3
        Label2.Text = "Comunidade SNMP"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(422, 46)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(235, 27)
        TextBox2.TabIndex = 2
        TextBox2.Text = ".1.3.6.1.2.1"
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(315, 46)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(101, 28)
        ComboBox1.TabIndex = 1
        ' 
        ' txt_endereço
        ' 
        txt_endereço.Location = New Point(6, 46)
        txt_endereço.Name = "txt_endereço"
        txt_endereço.Size = New Size(303, 27)
        txt_endereço.TabIndex = 1
        txt_endereço.Text = "10.0.0.248"
        txt_endereço.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 20)
        Label1.TabIndex = 0
        Label1.Text = "Endereço IP"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 152)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(833, 593)
        DataGridView1.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(864, 757)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MIB Browser"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_comunidade As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txt_endereço As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_pesquisa As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class

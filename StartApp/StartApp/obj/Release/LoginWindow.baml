   M S B A M L   `   `   `  ����   StartApp    StartApp.LoginWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    >d2http://schemas.microsoft.com/expression/blend/2008    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     �Name$  loginWindow�� � Icon$ /Images/UserPage.png�� � Title$ Login��$	��450��$	��720�����#F2F2F2 � 
ResizeMode$ NoResize=�.��� -   $��mainGrid��$��5q�.+�� -   $��Center=�$��Center=� � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto � � ColumnDefinitions �� $
��auto ��� $��* �.+��� $��10q�$��0��$��1��$��-NoLone-��$��24(����#797985   TextBlockStyle#��[  '  !MaterialDesignThemes.Wpf.PackIcon  $��1��   Kind$
 User=�  PackIconStyle#��[ �� $��5q�$��1��$��1�����#D8CDC9$��1q� �� CornerRadius$ 10��$��55��._��� -    ��Name$ txtUserName��$��5q�$��1��)  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 	User Name��  TextBoxStyle#��[ 
 �� 	MaxLength$
 50������ *
UserName+ +� FocusedElement �� *IsUserNameFocused+  $��2��$
 Lock=�#��[ �� $��5q�$��2��$��1�����#D8CDC9$��1q�$ 10��$��55��._�G� -    G�Name$ txtPassword��$��5q�$��2��$	 Password��  PasswordBoxStyle#��[  G� 	MaxLength$ 10�� �� *IsPasswordFocused+�� $��5q� �� Orientation$ 
Horizontal=�$��1��$��2��$��3��$	��210��$��Center=�.+��� -   $��
cbRemember�� d� 	IsChecked �� *IsRememberCheckBoxChecked+�� $��5q�$��Remember��$��SemiBold"����#797985$��Center=�$��70���� -    ��Name$ btnForgotPassword��$��Forgot Password?��
������ $��Segoe UI)�$��12(����#797985$��0q��� $��5q�$ 
Horizontal=�$��1��$��2��$��4��$��Center=�.+��� -   $ btnLogin��$��Login��  ButtonStyle#��[ ���� *LoginCommand+����  �� ElementName$ loginWindow���� -	   $ btnRegister��$��Register��#��[ ���� *RegisterCommand+���� $ loginWindow���� -
    ��Name$ 	tbLogfail��$��5��$��1�����#B90504#��[  ���� *Fail+y��� *FailVisibility+
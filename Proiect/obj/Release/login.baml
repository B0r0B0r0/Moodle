   M S B A M L   `   `   `  ���� B  >Proiect, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProiectProiect      Proiect.login   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Proiect       � WindowStartupLocation$  CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency . 
������  � Title$ login��$	��500��$	��800��.��� -    � ColumnDefinitions �� $��* ��� $
��1.5* �.+��� -   $��/Images/exit2.png��$��1�� K� ZIndex$ 1��   ImgClose#��[  ��  �� CornerRadius$ 
25 0 0 100������  �� 
StartPoint$	 0,0&� �� EndPoint$	 1,1&�.��� 	 � Color$	 #3AA9AD��
 � Offset$
 0Q�� $	 #3AADA1��$
 1Q�._�� .+��� .+��  � Points �    -1��� ;X�����#4EB1B6� ' �    �� �� ���� ��
�����#4EB1B6A� $��250 450 0 0q�$��40��$��40�����#4EB1B6A� $��
50 400 0 0q�$��20��$��40�����#4EB1B6�� $��Center=�.+��� $��Sign Up��  	titleText#��[ �� $E��?Enter your personal info and create a new account to connect us��  
normalText#��[  J� Opacity$	 0.8Q�$��20 30q��� -   $��Sign Up�� 
 button#��[ �� ���#ffffff$��1��$ 
0 100 25 0��._��� $��Center=�.+��� $��Sign in to App��#��[ ���#3AB19B$��Center=��� $��Use your email info:��#��[ ���#878787$��Center=��� $��1q����#ACB0AF$
��70 7q�$ 5��._�� $	��7 9q� �� $
��auto ��� $��* �.+��� $��/Images/email2.png��$��20���� -    ��Name$ 	textEmail��$��Email��  TextHint#��[ �� -    ��Name$ txtEmail��  TextBox#��[ �� $��1q����#ACB0AF$
��70 7q�$ 5��._�� $	��7 9q� �� $
��auto ��� $��* �.+��� $��/Images/lock2.png��$��20���� -   $ textPassword��$��Password��#��[ G� -    G�Name$ txtPassword��#��[ �� -   $��Sign in��  
mainButton#��[ 
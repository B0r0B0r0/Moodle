   M S B A M L   `   `   `  ���� B  >Proiect, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProiectProiect      Proiect.adminEnroll   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Proiect       � WindowStartupLocation$  CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency . 
������  � Title$ adminEnroll��$	��500��$	��800��.��� -    � ColumnDefinitions �� $��* ��� $��2* �.+��� -   $��/Images/exit2.png��$��1�� K� ZIndex$ 1��   ImgClose#��[  ��  �� CornerRadius$ 
25 0 0 100������  �� 
StartPoint$	 0,0&� �� EndPoint$	 1,1&�.��� 	 � Color$	 #3AA9AD��
 � Offset$
 0Q�� $	 #3AADA1��$
 1Q�._�� .+��� .+��  � Points �    -1��� ;X�����#4EB1B6� ' �    �� �� ���� ��
�����#4EB1B6A� $��250 450 0 0q�$��40��$��40�����#4EB1B6A� $��
50 400 0 0q�$��20��$��40�����#4EB1B6�� $��Center=�.+��� -     
menuButton#��[ $
��Home��
 � Tag$ /Images/menu.png���� -   #��[ $��Upgrade Account��$ /Images/upgrade.png���� #��[ $��Enroll��$ /Images/enroll.png���� -   #��[ $��Requests��$ /Images/request.png���� ���#ffffff$��1��$ 
0 100 25 0��._�� .+��� $��0,50,0,0q�.+��� $��Welcome to the,��  	titleText#��[ ���#3AB19B$��Center=�$��54��$��128,0q��� $��Enroll page!��#��[ ���#3AB19B$��Center=��� $�� ��#��[ $��Center=��� $M��GPlease select an account and a course (or a subject) you wish to enroll��  
normalText#��[ ���#878787$��Center=��� $��Account:��#��[ ���#878787$
��Left=�$��90,248,0,229q��� $��Enrollment:��#��[ ���#878787$
��Left=�$��90,293,0,183q��� -   $��selectStatus��$�� ��#��[ ���#878787$��10,400,10,10q��� -   $��Confirm!��  
mainButton#��[ $��Right=�$��
0,0,50,105q�$��Bottom=�$	��123���� -   $��userList��$��191,248,139,229q� �� 
IsEditable . �� -	   $��
enrollment��$��191,293,139,183q� . 
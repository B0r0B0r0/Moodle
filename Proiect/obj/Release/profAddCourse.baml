   M S B A M L   `   `   `  ���� B  >Proiect, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProiectProiect      Proiect.profAddCourse   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Proiect       � WindowStartupLocation$  CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency . 
������  � Title$ profAddCourse��$	��500��$	��800��.��� -    � ColumnDefinitions �� $��* ��� $��2* �.+��� -   $��/Images/exit2.png��$��1�� K� ZIndex$ 1��   ImgClose#��[  ��  �� CornerRadius$ 
25 0 0 100������  �� 
StartPoint$	 0,0&� �� EndPoint$	 1,1&�.��� 	 � Color$	 #3AA9AD��
 � Offset$
 0Q�� $	 #3AADA1��$
 1Q�._�� .+��� .+��  � Points �    -1��� ;X�����#4EB1B6� ' �    �� �� ���� ��
�����#4EB1B6A� $��250 450 0 0q�$��40��$��40�����#4EB1B6A� $��
50 400 0 0q�$��20��$��40�����#4EB1B6�� $��Center=�.+��� -     
menuButton#��[ $
��Home��
 � Tag$ /Images/menu.png���� -   #��[ $��
Add Course��$ /Images/course.png���� -   #��[ $��View Your Courses��$ /Images/viewCourses.png���� -   #��[ $��Request Enroll��$ /Images/reqEnroll.png���� -   #��[ $��Request Account Upgrade��$ /Images/reqUpgrade.png���� ���#ffffff$��1��$ 
0 100 25 0��._�� .+��� $��0,50,0,0q�.+��� $��Welcome to the,��  	titleText#��[ ���#3AB19B$��Center=�$��54��$��128,0q��� $��Add Course page!��#��[ ���#3AB19B$��Center=��� $�� ��#��[ $��Center=��� $H��BHere you can choose to add a course to a subject you are teaching!��  
normalText#��[ ���#878787$��Center=��� $��2��$
��Left=�$��23��$��
25,247,0,0q�$
��Wrap=�$��Select a subject��#��[ ���#878787$	��Top=�$	��120���� -   $
��subj��$��2��$
��Left=�$��159,247,0,0q�$	��Top=�$	��152��$��23�� �� 
IsEditable . �� $��2��$
��Left=�$��23��$��320,247,0,0q�$
��Wrap=�$��and the course:��#��[ ���#878787$	��Top=�$	��120���� $��445,247,65,230q�$��/Images/folder.png��$��2���� -	   $��buton��$��445,247,65,230q�$��2��
������ 
������ ��Z�  � FocusVisualStyle Z� �� $��2��$��25,286,442,194q�$��Preview:��#��[ ���#878787�� -
     
mainButton#��[ $��Submit��$��1��$��403,275,10,175q�$
��Auto��$	 100���� $��10 320 10 10q�$��2��$
��Auto=�$
��Auto=�.���� -   $��previewText��$�� ��
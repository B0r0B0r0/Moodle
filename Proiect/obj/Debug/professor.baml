   M S B A M L   `   `   `  ����B  >Proiect, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProiectProiect  5   	       Proiect.professor   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Proiect     5   	     � WindowStartupLocation$  CenterScreen=�5       � WindowStyle$
 None=�6?    � AllowsTransparency . 
������  � Title$ 	professor��5   	   $	��500��6   $	��800��6(   .��5
      � -   5         � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��2* �6   .+�5   
   �� -   5        $��/Images/exit2.png��5      $��1��6+    K� ZIndex$ 1��6;      ImgClose#��[  6h   �� 5   
   -   5        $��/Images/logout.png��5      $ 1��6,     	ImgLogOut#��[ 6[   $��35,35,207,435q�6~   �� 5   
    �� CornerRadius$ 
25 0 0 100��6   ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      � 	 � Color$	 #3AA9AD��6#   
 � Offset$
 0Q�63   � 5      $	 #3AADA1��6#   $
 1Q�63   5      ._�5      � .+�5      �� .+�5      �  � Points �    -1��� ;X�����#4EB1B66:   � 5      ' �    �� �� ���� ��
�����#4EB1B66?   A� 5      $��250 450 0 0q�6   $��40��63   $��40��6>   ���#4EB1B66J   A� 5       $��
50 400 0 0q�6   $��20��62   $��40��6=   ���#4EB1B66I   5!      �� 5#      $��Center=�6   .+�5$      �� -   5          
menuButton#��[ 5$      $
��Home��6A   
 � Tag$ /Images/menu.png��6P   6g   �� 5%      -   5        #��[ 5%      $��
Add Course��6A   $ /Images/course.png��6V   6o   �� 5&      -   5        #��[ 5&      $��View Your Courses��6A   $ /Images/viewCourses.png��6]   6{   �� 5'      -   5        #��[ 5'      $��Request Enroll��6A   $ /Images/reqEnroll.png��6Z   6v   �� 5(      -   5        #��[ 5(      $��Request Account Upgrade��6A   $ /Images/reqUpgrade.png��6c   6�   5)      5+      5.      �� 50   
   ���#ffffff$��1��6&   $ 
0 100 25 0��66   ._�51      � .+�52      �� $��0,50,0,0q�6   .+�53      �� $��Welcome to the,��6      	titleText#��[ 67   ���#3AB19B$��Center=�6o   $��54��6�   $��128,0q�6�   �� 54      $��Professor page!��6    #��[ 67   ���#3AB19B$��Center=�6o   �� 55      $�� ��6    #��[ 6(   $��Center=�6K   �� 56      $H��BHere you can choose to add a course to a subject you are teaching!��6      
normalText#��[ 6j   ���#878787$��Center=�6�   �� 57      $�� ��6    $��Center=�6(   �� 58      $L��FYou can see your already submitted courses! (You can also delete them)��6    #��[ 6n   ���#878787$��Center=�6�   �� 59      $�� ��6    $��Center=�6(   �� 5:      $6��0You can request to be enrolled to a new subject!��6    #��[ 6X   ���#878787$��Center=�6�   �� 5;      $�� ��6    $��Center=�6(   �� 5<      $)��#You can request an account upgrade!��6    #��[ 6K   ���#878787$��Center=�6�   �� 5=      $�� ��6    $��Center=�6(   �� 5>      $]��WEvery request will be treated by an administrator and will be dealt with appropriately!��6    #��[ 6   ���#878787$��Center=�6�   5@      5C      5D      5H      5I      
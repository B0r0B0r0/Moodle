   M S B A M L   `   `   `  ����B  >Proiect, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProiectProiect  5   	       Proiect.admin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Proiect     5   	     � WindowStartupLocation$  CenterScreen=�5       � WindowStyle$
 None=�6?    � AllowsTransparency . 
������  � Title$ admin��5   	   $	��500��6   $	��800��6$   .��5
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
 � Tag$ /Images/menu.png��6P   6g   �� 5%      -   5        #��[ 5%      $��Upgrade Account��6A   $ /Images/upgrade.png��6[   6u   �� 5&      -   5        #��[ 5&      $��Enroll��6A   $ /Images/enroll.png��6R   6k   �� 5'      -   5        #��[ 5'      $��Requests��6A   $ /Images/request.png��6T   6n   5(      5*      5-      �� 5/   
   ���#ffffff$��1��6&   $ 
0 100 25 0��66   ._�50      �� $��Center=�6   .+�51      �� $��Welcome to the,��6     	titleText#��[ 63   ���#3AB19B$��Center=�6k   �� 52      $��Admin page!��6   #��[ 6/   ���#3AB19B$��Center=�6g   �� 53      $�� ��6   #��[ 6$   $��Center=�6G   �� 54      $p��jHere you can choose to upgrade an account, or downgrade an account by clicking the upgrade account button!��6     
normalText#��[ 6�   ���#878787$��Center=�6�   �� 55      $�� ��6   $��Center=�6$   �� 56      $q��kYou can help students enroll to new courses or even cancel their membership, by clicking the Enroll button!��6   #��[ 6�   ���#878787$��Center=�6�   �� 57      $�� ��6   $��Center=�6$   �� 58      $`��ZYou can see the requests you have from different accounts by clicking the Requests button!��6   #��[ 6~   ���#878787$��Center=�6�   5;      5=      5A      5B      
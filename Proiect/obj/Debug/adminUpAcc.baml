   M S B A M L   `   `   `  ����B  >Proiect, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProiectProiect  5   	       Proiect.adminUpAcc   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Proiect     5   	     � WindowStartupLocation$  CenterScreen=�5       � WindowStyle$
 None=�6?    � AllowsTransparency . 
������  � Title$ 
adminUpAcc��5   	   $	��500��6   $	��800��6)   .��5
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
0 100 25 0��66   ._�50      � .+�51      �� $��0,30,0,0q�6   .+�52      �� $��Welcome to the,��6      	titleText#��[ 67   ���#3AB19B$��Center=�6o   �� 53      $��Upgrade Account page!��6    #��[ 6=   ���#3AB19B$��Center=�6u   �� 54      $�� ��6    #��[ 6(   $��Center=�6K   �� 55      $Q��KPlease select an account and the upgrade (or downgrade) you wish to provide��6      
normalText#��[ 6s   ���#878787$��Center=�6�   �� 56      $�� ��6    $��Center=�6(   �� 57      $��Account:��6    #��[ 60   ���#878787$
��Left=�6u   $��	100,0,0,0q�6�   �� 58      $�� ��6    $��Center=�6(   �� 59      $��Upgrade:��6    #��[ 60   ���#878787$
��Left=�6u   $��	100,0,0,0q�6�   5:      �� 5<      -   5        $��selectStatus��5<      $�� ��60   #��[ 68   ���#878787$��10,400,10,10q�6}   �� 5=      -	   5        $��Confirm!��5=        
mainButton#��[ 6,   $��Right=�6P   $��
0,0,50,105q�6l   $��Bottom=�6�   $	��123��6�   6�   �� 5>      -
   5        $��userList��5>      $��191,248,139,229q�6+    �� 
IsEditable . 6D   �� 5?      -   5        $��upgrades��5?      $��191,293,139,183q�6+    . 6D   5A      5B      5F      5G      
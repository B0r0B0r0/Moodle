   M S B A M L   `   `   `  ����B  >Proiect, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProiectProiect  5   	       Proiect.login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Proiect     5   	     � WindowStartupLocation$  CenterScreen=�5       � WindowStyle$
 None=�6?    � AllowsTransparency . 
������  � Title$ login��5   	   $	��500��6   $	��800��6$   .��5	      � -   5         � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��1.5* �6   .+�5   
   �� -   5        $��/Images/exit2.png��5      $��1��6+    K� ZIndex$ 1��6;      ImgClose#��[  6h   �� 5   
    �� CornerRadius$ 
25 0 0 100��6   ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      � 	 � Color$	 #3AA9AD��6#   
 � Offset$
 0Q�63   � 5      $	 #3AADA1��6#   $
 1Q�63   5      ._�5      � .+�5      �� .+�5      �  � Points �    -1��� ;X�����#4EB1B66:   � 5      ' �    �� �� ���� ��
�����#4EB1B66?   A� 5      $��250 450 0 0q�6   $��40��63   $��40��6>   ���#4EB1B66J   A� 5      $��
50 400 0 0q�6   $��20��62   $��40��6=   ���#4EB1B66I   5      �� 5!      $��Center=�6   .+�5"      �� $��Sign Up��6      	titleText#��[ 6/   �� 5#      $E��?Enter your personal info and create a new account to connect us��6      
normalText#��[ 6g    J� Opacity$	 0.8Q�6�   $��20 30q�6�   �� 5$      -   5        $��Sign Up��5$       
 button#��[ 6/   6O   5%      5&      5'      �� 5)   
   ���#ffffff$��1��6&   $ 
0 100 25 0��66   ._�5*      �� $��Center=�6   .+�5+      �� $��Sign in to App��6   #��[ 62   ���#3AB19B$��Center=�6j   �� 5,      $��Use your email info:��6   #��[ 68   ���#878787$��Center=�6}   �� 5.      $��1q�6   ���#ACB0AF$
��70 7q�6C   $ 5��6Q   ._�5/      � $	��7 9q�6    50      �� 51      $
��auto �6/   �� 52      $��* �6/   .+�55      �� $��/Images/email2.png��6    $��20��6<   �� 56      -   5         ��Name$ 	textEmail��56   $   $��Email��6X     TextHint#��[ 6e   �� 57      -   5         ��Name$ txtEmail��57   "     TextBox#��[ 6W   58      59      �� 5;      $��1q�6   ���#ACB0AF$
��70 7q�6C   $ 5��6Q   ._�5<      � $	��7 9q�6    5=      �� 5>      $
��auto �6/   �� 5?      $��* �6/   .+�5B      �� $��/Images/lock2.png��6    $��20��6;   �� 5C      -   5        $ textPassword��5C   $   $��Password��6]   #��[ 6m   G� 5D      -   5         G�Name$ txtPassword��5D   &   #��[ 6i   5E      5F      �� 5H      -   5        $��Sign in��5H        
mainButton#��[ 6@   5K      5L      5P      5Q      
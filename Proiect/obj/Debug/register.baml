   M S B A M L   `   `   `  ����B  >Proiect, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProiectProiect  5   	       Proiect.register   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Proiect     5   	     � WindowStartupLocation$  CenterScreen=�5       � WindowStyle$
 None=�6?    � AllowsTransparency . 
������  � Title$ register��5   	   $	��500��6   $	��800��6'   .��5	      � -   5         � ColumnDefinitions 5
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
50 400 0 0q�6   $��20��62   $��40��6=   ���#4EB1B66I   5      �� 5!      $��Center=�6   .+�5"      �� $��Sign In��6      	titleText#��[ 6/   �� 5#      $0��*Enter your personal info and to connect us��6      
normalText#��[ 6R    J� Opacity$	 0.8Q�6v   $��20 30q�6�   �� 5$      -   5        $��Sign In��5$       
 button#��[ 6/   6O   5%      5&      5'      �� 5)   
   ���#ffffff$��1��6&   $ 
0 100 25 0��66   ._�5*      �� $��Center=�6   .+�5+      �� $��Sign up to App��6   #��[ 62   ���#3AB19B$��Center=�6j   �� 5,      $��Use your info:��6   #��[ 62   ���#878787$��Center=�6w   �� 5.      $��1q�6   ���#ACB0AF$
��70 7q�6C   $ 5��6Q   ._�5/      � $	��7 9q�6    50      �� 51      $
��auto �6/   �� 52      $��* �6/   .+�55      �� $��/Images/user2.png��6    $��20��6;   �� 56      -   5         ��Name$ textUsername��56   $   $��Display Name��6^     TextHint#��[ 6r   $��20��6�   $��Bottom=�6�   �� 57      -   5         ��Name$ txtUsername��57   "     TextBox#��[ 6]   58      59      �� 5;      $��1q�6   ���#ACB0AF$
��70 7q�6C   $ 5��6Q   ._�5<      � $	��7 9q�6    5=      �� 5>      $
��auto �6/   �� 5?      $��* �6/   .+�5B      �� $��/Images/email2.png��6    $��20��6<   �� 5C      -   5        $ 	textEmail��5C   $   $��Email��6X   #��[ 6e   �� 5D      -   5        $ txtEmail��5D   "   #��[ 6W   5E      5F      �� 5H      $��1q�6   ���#ACB0AF$
��70 7q�6C   $ 5��6Q   ._�5I      � $	��7 9q�6    5J      �� 5K      $
��auto �6/   �� 5L      $��* �6/   .+�5O      �� $��/Images/lock2.png��6    $��20��6;   �� 5P      -   5        $ textPassword��5P   $   $��Password��6]   #��[ 6m   G� 5Q      -	   5         G�Name$ txtPassword��5Q   &   #��[ 6i   5R      5S      �� 5U      $��1q�6   ���#ACB0AF$
��70 7q�6C   $ 5��6Q   ._�5V      � $	��7 9q�6    5W      �� 5X      $
��auto �6/   �� 5Y      $��* �6/   .+�5\      �� $��/Images/lock2.png��6    $��20��6;   �� 5]      -
   5        $ textRepeatPassword��5]   $   $��Repeat Password��6i   #��[ 6�   G� 5^      -   5        $ txtRepeatPassword��5^   &   #��[ 6u   5_      5`      �� 5b      -   5        $��Sign Up��5b        
mainButton#��[ 6@   5e      5f      5j      5k      
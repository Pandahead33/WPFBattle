   M S B A M L   `   `   `  ����D  @WPFBattle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WPFBattle	WPFBattle  5   	       WPFBattle.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WPFBattle     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      � .+�5   
   �� -   5         ��Name$ image��5      $
��Left=�6   $	��319��6:   $	��Top=�6G   $	��517��6_   $��/content/background.jpg��6k   $��UniformToFill=�6�   �� 5   
   -   5         ��Name$ textBox��5      $
��Left=�6#   $��87��6>   $��
10,222,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��264��6�   
�������
���   �.��6�    �� SelectionBrush 5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5      $	 Red��6#   $ 1Q�6/   5      .��5   &   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ Black��6#   $ 0Q�61   � 5      $ 	#FFDE8F8F��6#   $ 1Q�65   5      .��5   "   5         WPFBattle.CharacterImage  5   
   -   5        	  Name$	 characterImage��5      $
��Left=�67   $��80��6R   $��
195,99,0,0q�6^   $	��Top=�6r   $��87��6�   
   IdleImageSource$
 content/Riku_idle.png��6�      DeadImageSource$ content/Riku_dead.png��6�      AttackingImageSource$ content/Riku_attack.png��6�      TakeDamageImageSource$ content/Riku_hurt.png��6   J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5        5   
   -   5        $	 characterImage1��5      $
��Left=�68   $��76��6S   $��
138,85,0,0q�6_   $	��Top=�6s   $��81��6�   $ content/Xenmas_attack.png��6�   $ content/Xenmas_dead.png��6�   $
 content/Xenmas_idle.png��6�   $ content/Xenmas_hurt.png��6   5         5!      5#        5$   
   -   5        $	 characterImage2��5$      $
��Left=�68   $��93��6S   $��329,185,0,0q�6_   $	��Top=�6t   $��91��6�   $ content/Flare_attack.png��6�   $ content/Flare_dead.png��6�   $
 content/Flare_idle.png��6�   $ content/Flare_hurt.png��6   5%        5&      5(        5)   
   -   5        $	 characterImage3��5)      $
��Left=�68   $��86��6S   $��389,175,0,0q�6_   $	��Top=�6t   $��97��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $ content/Vexen_attack.png��6�   $ content/Vexen_dead.png��6�   $ content/Vexen_hurt.png��6  $
 content/Vexen_idle.png��6?   5*        5+      z�5-      V� 5.      .~�5/      �� �� 50      �� 51       �� Angle$ 3.723Q�6&   T� 52      53      55      57      58      
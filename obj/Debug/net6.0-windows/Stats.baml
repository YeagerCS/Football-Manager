   M S B A M L   `   `   `  ????K  GFootball Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Football_ManagerFootball_Manager  5   	       Football_Manager.Stats   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Football_Manager     5   	     ? Title$  TeamManagement??5   	   $	??700??6    $
??1353??6-   .??5	      ? ???	#FF1E1E1E$
??1353??6"   $	??700??6/   .+?5   
   ?? $??
Statistics??6   $
??Left=?6%   $??
538,-2,0,0q?6@   $	??Top=?6T   $	??611??6l   
???????$??Arial Rounded MT Bold)?6?   $??60(?6?    J? RenderTransformOrigin$ 1.089,0.763&?6?   ?? 5   
   $??Matches Played??6   $
??Left=?6)   $??
10,241,0,0q?6D   $	??Top=?6X   $	??408??6p   
???????$??Arial Rounded MT Bold)?6?   $??52(?6?   $ 1.089,0.763&?6?   ?? 5   
   -   5         ??Name$ benchlbl??5      $
??Wins??6"   $
??Left=?61   $??444,241,0,0q?6L   $	??Top=?6a   $	??188??6y   ???	#FFABFF00$??Arial Rounded MT Bold)?6?   $??52(?6?   $ 1.089,0.763&?6?   ?? 5   
   -   5         ??Name$ backBtn??5      $
??Back??6"   $
??Left=?61   $??	36,31,0,0q?6L   $	??Top=?6_   $??58??6w   $	??163??6?   ???	#FF1E1E1E
???????
???????$??Arial)?6?   $??36(?6?   6?   ?? 5   
   -   5        $ benchlbl_Copy??5      $??Team Rating:??6'   $
??Left=?6>   $??944,111,0,0q?6Y   $	??Top=?6n   $	??276??6?   
???????$??Arial Rounded MT Bold)?6?   $??36(?6?   $ 1.089,0.763&?6?   ?? 5   
   -   5        $ 	ratingLbl??5      $??##??6#   $
??Left=?60   $??1194,114,0,0q?6K   $	??Top=?6a   $	??113??6y   ???	#FFFDFF01$??Arial Rounded MT Bold)?6?   $??36(?6?   $ 1.089,0.763&?6?   ?? 5   
   -   5        $ benchlbl_Copy1??5      $??Draws??6(   $
??Left=?68   $??608,241,0,0q?6S   $	??Top=?6h   $	??188??6?   ???	#FFFFBB00$??Arial Rounded MT Bold)?6?   $??52(?6?   $ 1.089,0.763&?6?   ?? 5   
   -   5        $ benchlbl_Copy2??5      $??Losses??6(   $
??Left=?69   $??801,241,0,0q?6T   $	??Top=?6i   $	??188??6?   ???	#FFD02D25$??Arial Rounded MT Bold)?6?   $??52(?6?   $ 1.089,0.763&?6?   ?? 5   
   -   5        $ benchlbl_Copy3??5      $??Total Goals??6(   $
??Left=?6>   $??1021,241,0,0q?6Y   $	??Top=?6o   $	??322??6?   ???	#FF406D22$??Arial Rounded MT Bold)?6?   $??52(?6?   $ 1.089,0.763&?6?   ?? 5   
   -   5        $ matchesPlayed??5      $?? ??6'   $
??Left=?62   $??
10,331,0,0q?6M   $	??Top=?6a   $	??364??6y   ???	#FFFDFF01$??Arial Rounded MT Bold)?6?   $??52(?6?   $ 1.089,0.763&?6?   ?? 5   
   -	   5        $
 wins??5      $?? ??6   $
??Left=?6)   $??444,331,0,0q?6D   $	??Top=?6Y   $	??122??6q   ???	#FFFDFF01$??Arial Rounded MT Bold)?6?   $??52(?6?   $ 1.089,0.763&?6?   ?? 5   
   -
   5        $ draws??5      $?? ??6   $
??Left=?6*   $??608,331,0,0q?6E   $	??Top=?6Z   $	??174??6r   ???	#FFFDFF01$??Arial Rounded MT Bold)?6?   $??52(?6?   $ 1.089,0.763&?6?   ?? 5   
   -   5        $ losses??5      $?? ??6    $
??Left=?6+   $??801,331,0,0q?6F   $	??Top=?6[   $	??174??6s   ???	#FFFDFF01$??Arial Rounded MT Bold)?6?   $??52(?6?   $ 1.089,0.763&?6?   ?? 5   
   -   5        $ goalsLbl??5      $?? ??6"   $
??Left=?6-   $??1021,331,0,0q?6H   $	??Top=?6^   $	??261??6v   ???	#FFFDFF01$??Arial Rounded MT Bold)?6?   $??52(?6?   $ 1.089,0.763&?6?   ?? 5   
   $??Coins:??6   $
??Left=?6!   $??
10,547,0,0q?6<   $	??Top=?6P   $	??408??6h   
???????$??Arial Rounded MT Bold)?6?   $??52(?6?   $ 1.089,0.763&?6?   ?? 5   
   -   5        $ coinLbl??5      $?? ??6!   $
??Left=?6,   $??214,547,0,0q?6G   $	??Top=?6\   $	??364??6t   ???	#FFFDFF01$??Arial Rounded MT Bold)?6?   $??52(?6?   $ 1.089,0.763&?6?   ?? 5   
   -   5        $ allPlayerBtn??5      $??View All Players??6'   $
??Left=?6B   $??1021,560,0,0q?6]   $	??Top=?6s   $??58??6?   $	??293??6?   ???	#FF1E1E1E
???????
???????$??Arial)?6?   $??36(?6?   6  ? 5   
   -   5         ?Name$ grid2??5      $??Center=?6   $	??636??6;   $??0,10,0,0q?6H   $	??Top=?6Z   $
??1322??6r   ???	#FF1E1E1E.+?5      ?? $??Player Statistics??6   $
??Left=?60   $??	391,0,0,0q?6K   $	??Top=?6^   $	??611??6v   
???????$??Arial Rounded MT Bold)?6?   $??60(?6?   $ 1.089,0.763&?6?   ?? 5      -   5         ??Name$ startingLbx??5   ?   $
??Left=?6?   $	??462??6?   $??
50,140,0,0q?6?   $	??Top=?6?   $	??560??6?   $??Arial Rounded MT Bold)?6!  $??30(?6D  ???	#FF1E1E1E
???????
?????????6   ?? *	Players+ ?? SelectedItem 66   ?? *SelectedItem+ ?? UpdateSourceTrigger$ PropertyChanged=???5      ?? 5       .R?5!      ?? ??6$   ?? *DisplayString+5"      5$      ?? 5%      $??Players??6   $
??Left=?6&   $??
224,74,0,0q?6A   $	??Top=?6U   $	??212??6m   ???	#FFFFF500$??Arial Rounded MT Bold)?6?   $??48(?6?   $ 1.089,0.763&?6?   ??6?   Z? ?? 5&      -   5        $ backBtn2??5&      $
??Back??6'   $
??Left=?66   $??	36,31,0,0q?6Q   $	??Top=?6d   $??58??6|   $	??163??6?   ???	#FF1E1E1E
???????
???????$??Arial)?6?   $??36(?6?   6?   ?? 5'      $??Rating:??6   $
??Left=?6&   $??696,122,0,0q?6A   $	??Top=?6V   $	??212??6n   ???	#FFFFF500$??Arial Rounded MT Bold)?6?   $??48(?6?   $ 1.089,0.763&?6?   ??6?   Z? ?? 5(      $??	Position:??6   $
??Left=?6(   $??696,252,0,0q?6C   $	??Top=?6X   $	??212??6p   ???	#FFFFF500$??Arial Rounded MT Bold)?6?   $??48(?6?   $ 1.089,0.763&?6?   ??6?   Z? ?? 5)      $??Shirtnr:??6   $
??Left=?6'   $??696,387,0,0q?6B   $	??Top=?6W   $	??212??6o   ???	#FFFFF500$??Arial Rounded MT Bold)?6?   $??48(?6?   $ 1.089,0.763&?6?   ??6?   Z? ?? 5*      $??Goals:??6   $
??Left=?6%   $??696,536,0,0q?6@   $	??Top=?6U   $	??212??6m   ???	#FFFFF500$??Arial Rounded MT Bold)?6?   $??48(?6?   $ 1.089,0.763&?6?   ??6?   Z? ?? 5+      -   5        $ playerRatingLbl??5+      $?? ??6-   $
??Left=?68   $??RightToLeft=?6S   $??913,122,0,0q?6o   $	??Top=?6?   $	??212??6?   $??Arial Rounded MT Bold)?6?   $??48(?6?   $ 1.089,0.763&?6?   ???	#FF71FF00??6?   Z? 6  ?? 5,      -   5        $ playerPositionLbl??5,      $?? ??6/   $
??Left=?6:   $??RightToLeft=?6U   $??913,252,0,0q?6q   $	??Top=?6?   $	??212??6?   $??Arial Rounded MT Bold)?6?   $??48(?6?   $ 1.089,0.763&?6?   ???	#FF71FF00??6?   Z? 6  ?? 5-      -   5        $ playerShirtnrLbl??5-      $?? ??6.   $
??Left=?69   $??RightToLeft=?6T   $??913,387,0,0q?6p   $	??Top=?6?   $	??212??6?   $??Arial Rounded MT Bold)?6?   $??48(?6?   $ 1.089,0.763&?6?   ???	#FF71FF00??6?   Z? 6  ?? 5.      -   5        $ playerGoalsLbl??5.      $?? ??6,   $
??Left=?67   $??RightToLeft=?6R   $??913,536,0,0q?6n   $	??Top=?6?   $	??212??6?   $??Arial Rounded MT Bold)?6?   $??48(?6?   $ 1.089,0.763&?6?   ???	#FF71FF00??6?   Z? 6  50      52      53      
import { Component } from '@angular/core';
import { RouterLink, RouterLinkActive } from '@angular/router';
import { lucideHouse, lucideBookMarked, lucideCircleStar } from '@ng-icons/lucide';
import { NgIcon, provideIcons } from '@ng-icons/core';
import { NAV_ITEMS } from '../navigation-items';

@Component({
  imports: [RouterLink, RouterLinkActive, NgIcon],
  selector: 'app-mobile-navbar',
  styleUrl: './mobile-navbar.css',
  templateUrl: './mobile-navbar.html',
  providers: [
    provideIcons({
      lucideHouse,
      lucideBookMarked,
      lucideCircleStar
    })
  ]
})
export class MobileNavbar {
  protected readonly _items = NAV_ITEMS;
}

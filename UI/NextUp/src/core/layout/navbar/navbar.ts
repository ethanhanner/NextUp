import { Component } from '@angular/core';
import { lucideHouse, lucideBookMarked, lucideCircleStar } from '@ng-icons/lucide';
import { NgIcon, provideIcons } from '@ng-icons/core';
import { NAV_ITEMS } from '../navigation-items';
import { RouterLink, RouterLinkActive } from '@angular/router';

@Component({
  imports: [NgIcon, RouterLink, RouterLinkActive],
  selector: 'app-navbar',
  styleUrl: './navbar.css',
  templateUrl: './navbar.html',
  providers: [
    provideIcons({
      lucideHouse,
      lucideBookMarked,
      lucideCircleStar
    })
  ]
})
export class Navbar {
  protected readonly _items = NAV_ITEMS;
}

import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Navbar } from '../core/layout/navbar/navbar';
import { MobileNavbar } from '../core/layout/mobile-navbar/mobile-navbar';


@Component({
  imports: [RouterOutlet, Navbar, MobileNavbar],
  selector: 'app-root',
  styleUrl: './app.css',
  templateUrl: './app.html',
})
export class App {
  protected readonly title = signal('NextUp');
}

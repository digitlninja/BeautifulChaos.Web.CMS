import { Component, OnInit } from '@angular/core';


interface IRouteInfo {
    path: string;
    title: string;
    icon: string;
    class: string;
}
//const $: window;
export const routes: IRouteInfo[] = [
    { path: 'dashboard', title: 'Dashboard', icon: 'dashboard', class: '' },
    { path: 'profile', title: 'My Profile', icon: 'person', class: '' },
    { path: 'home', title: 'Home', icon: 'person', class: '' },
    { path: 'about', title: 'About', icon: 'content_paste', class: '' },
    { path: 'services', title: 'Services', icon: 'library_books', class: '' },
    { path: 'work', title: 'Work', icon: 'bubble_chart', class: '' },
    { path: 'testimonials', title: 'Testimonials', icon: 'location_on', class: '' },
    { path: 'contact', title: 'Contact', icon: 'notifications', class: '' },
];

@Component({
    selector: 'app-sidebar',
    templateUrl: './sidebar.component.html',
    styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent implements OnInit {
    menuItems: any[];

    ngOnInit() {
        this.menuItems = routes.filter(menuItem => menuItem);
    }

    isMobileMenu() {
        
//        if ($(window).width() > 991) {
//            return false;
//        }
        return true;
    };
}

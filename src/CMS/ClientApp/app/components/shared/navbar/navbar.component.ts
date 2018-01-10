import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
    selector: 'app-navbar',
    templateUrl: './navbar.component.html'
})
export class NavBarComponent{

    title: string;
    constructor(private router: Router) { }

    getTitle() {
        let currentUrl = this.router.url; /// this will give you current url
        return currentUrl.substring(1).toUpperCase();

    }
}



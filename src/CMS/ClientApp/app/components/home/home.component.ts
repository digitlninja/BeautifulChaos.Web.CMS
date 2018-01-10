import { Component } from '@angular/core';
import { HomeService } from '../../services/home-service';

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent {
    title: string;
    model: any;

    // ng automatically instantiates service
    constructor(service: HomeService) {
        let homeService = new HomeService;

        this.title = "Home";

    }
}

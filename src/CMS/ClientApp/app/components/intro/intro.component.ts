import { Component, Input } from '@angular/core';

@Component({
    selector: 'introduction',
    templateUrl: './intro.component.html',
    styleUrls: ['./intro.component.css']
})
/** intro component*/
export class IntroComponent {

    @Input() headTitle: string;
    @Input() _subTitle: string;

    get subTitle() {
        return this.headTitle.toLowerCase();
    }

    constructor() {
        this.headTitle = "Introduction";
    }
}
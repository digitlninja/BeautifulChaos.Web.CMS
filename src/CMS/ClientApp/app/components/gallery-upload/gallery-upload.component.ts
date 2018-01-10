import { Component, Input } from '@angular/core';

@Component({
    selector: 'gallery-upload',
    templateUrl: './gallery-upload.component.html',
    styleUrls: ['./gallery-upload.component.css'],
})

export class GalleryUploadComponent {
    @Input() headTitle: string;
    @Input() _subTitle: string;

    constructor() {
        this.headTitle = "Gallery";
    }

    get subTitle() {
        return this.headTitle.toLowerCase();
    }
}
/// <reference path="../../../../node_modules/@types/jasmine/index.d.ts" />
import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { GalleryUploadComponent } from './gallery-upload.component';

let component: GalleryUploadComponent;
let fixture: ComponentFixture<GalleryUploadComponent>;

describe('gallery-upload component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ GalleryUploadComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(GalleryUploadComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});
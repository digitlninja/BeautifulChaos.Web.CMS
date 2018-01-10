/// <reference path="../../../../node_modules/@types/jasmine/index.d.ts" />
import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { BasicInfoComponent } from './basic-info.component';

let component: BasicInfoComponent;
let fixture: ComponentFixture<BasicInfoComponent>;

describe('basic-info component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ BasicInfoComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(BasicInfoComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});
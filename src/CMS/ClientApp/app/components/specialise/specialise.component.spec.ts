/// <reference path="../../../../node_modules/@types/jasmine/index.d.ts" />
import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { SpecialiseComponent } from './specialise.component';

let component: SpecialiseComponent;
let fixture: ComponentFixture<SpecialiseComponent>;

describe('specialise component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ SpecialiseComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(SpecialiseComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});
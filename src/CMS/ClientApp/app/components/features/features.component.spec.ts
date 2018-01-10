/// <reference path="../../../../node_modules/@types/jasmine/index.d.ts" />
import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { FeaturesComponent } from './features.component';

let component: FeaturesComponent;
let fixture: ComponentFixture<FeaturesComponent>;

describe('features component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ FeaturesComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(FeaturesComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});
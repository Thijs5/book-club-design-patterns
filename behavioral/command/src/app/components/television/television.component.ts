import { AfterViewInit, Component, ElementRef, EventEmitter, Input, Output, ViewChild } from '@angular/core';
import * as $ from 'jquery';
import { ICommand, MoveDownCommand, MoveUpCommand, TogglePowerCommand } from 'src/app/models/commands';
import { Television } from 'src/app/models/television';

@Component({
  selector: 'app-television',
  templateUrl: './television.component.html',
  styleUrls: ['./television.component.scss']
})
export class TelevisionComponent implements AfterViewInit {
  @ViewChild('myCanvas', { static: false }) myCanvas: ElementRef<HTMLCanvasElement>;
  @Output() onPress = new EventEmitter<ICommand>();

  @Input() television: Television;

  moveUp() {
    this.onPress.emit(new MoveUpCommand(this.television));
  }

  moveDown() {
    this.onPress.emit(new MoveDownCommand(this.television));
  }

  toggleOn() {
    this.onPress.emit(new TogglePowerCommand(this.television));
  }

  ngAfterViewInit() {
    const that = this;
    var main = document.querySelector('main'),
      canvas = this.myCanvas.nativeElement,
      ctx = this.myCanvas.nativeElement.getContext('2d'),
      text = document.querySelector('.text'),
      ww = window.innerWidth,
      menu = document.querySelector('.menu'),
      ul = menu.querySelector('ul'),
      idx = 0,
      count = ul.childElementCount - 1,
      toggle = true,
      frame;

    // Set canvas size
    canvas.width = ww / 3;
    canvas.height = (ww * 0.5625) / 3;

    // Generate CRT noise
    function snow() {

      var w = ctx.canvas.width,
        h = ctx.canvas.height,
        d = ctx.createImageData(w, h),
        b = new Uint32Array(d.data.buffer),
        len = b.length;

      for (var i = 0; i < len; i++) {
        b[i] = ((255 * Math.random()) | 0) << 24;
      }

      ctx.putImageData(d, 0, 0);
    }

    function animate() {
      snow();
      frame = requestAnimationFrame(animate);
    };

    // Glitch
    for (let i = 0; i < 4; i++) {
      var span = text.firstElementChild.cloneNode(true);
      text.appendChild(span);
    }

    // window.addEventListener('DOMContentLoaded', function (e) {
    //   setTimeout(function () {
    //     that.television.poweredOn = true;
    //     // main.classList.add('on');
    //     // main.classList.remove('off');
    //     animate();
    //   }, 1000);
    // });

    window.addEventListener('keydown', function (e) {
      var key = e.keyCode;
      var prev = idx;
      if (key == 27 || key == 38 || key == 40) {
        e.preventDefault();

        switch (key) {
          case 27:
            that.toggleOn();
            break;
          case 38:
            that.moveUp();
            break;
          case 40:
            that.moveDown();
            break;
        }
      }
    }, false);
  }
}

import { TreeDecorator } from './TreeDecorator';
import { IChristmasTree } from './IChristmasTree';

export class Lights extends TreeDecorator {
    constructor(tree: IChristmasTree) {
        super(tree);
    }

    public decorate(): string[] {
        const tree = super.decorate();
        tree.push(this.decorateWithLights());
        return tree;
    }

    private decorateWithLights(): string {
        return 'lights';
    }
}
